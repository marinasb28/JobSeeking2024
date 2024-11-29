import streamlit as st
import INTERVIEW.COGNIZANT.STREAMLIT.main_cognizant as mp
import pandas as pd
import numpy as np
import altair as alt

from pandas_profiling import ProfileReport
from streamlit_pandas_profiling import st_profile_report
#from ydata_profiling import ProfileReport

import folium
from streamlit_folium import st_folium


if not st.session_state.page == "Tableau":
    st.set_page_config(
    page_title="EDA HR Dashboard",
    page_icon="📊"
    )

# SIDEBAR menu
st.sidebar.title("Pages")
st.sidebar.page_link(mp.home,label="Home",icon="🏘️")
st.sidebar.page_link(mp.about_me,label="About me",icon="👩🏾‍🎓")
st.sidebar.page_link(mp.tableau_pg,label="Tableau",icon="📊")
st.sidebar.page_link(mp.prediction_pg,label="Prediction",icon="🔮")
st.sidebar.page_link(mp.contact_me,label="Contact me",icon="📧")



st.title('📊 EDA HR Dashboard')

# App description - Explain functionalities in an expander box
with st.expander('About this app'):

    st.markdown('**What can this app do?**')
    st.info("""Imagine you are an HR manager, and you discover a tool that offers a comprehensive dashboard designed to analyze human resources data.
            This tool provides clear summary views for high-level insights and gives access to detailed employee records for in-depth analysis,
            making it invaluable for managing workforce trends and individual employee metrics alike.
            """)
    st.markdown('**What can we observe?**')
    st.warning("""The data used in this HR Dashboard project is created using ChatGPT and the Python library Faker.
               \nThis dataset represents fictional employee information that you might find in a human resources (HR) system.
               \nIt includes details like personal information, job roles, salaries, performance reviews, and information about employees leaving the company. The goal of generating this data is to make it look similar to real HR data, allowing us to analyze and visualize it effectively using Tableau.
        """)

    st.markdown('**How to use the app:**')
    st.success("""Here’s how you can engage with the app:
                \n1. Take a moment to review the data and ensure you have a good understanding of it.
                \n2. Once you feel comfortable, feel free to explore the filters and interact with the data.
                \nHope you enjoy using the app!
                """)

  
code = """
# Initialize Faker
fake = Faker('nl_NL')
Faker.seed(42)
np.random.seed(42)
random.seed(42)

# Configuration
num_records = 10000"""

st.code(code, language="python")

df = pd.read_csv(mp.hr_records)

# Capitalize column names and replace underscores with spaces
df.columns = [col.replace('_', ' ').title() for col in df.columns]

# EDA PART
st.markdown("<h1>Human <span style='color: orange;'>Resources</span> Dataframe</h1>",
            unsafe_allow_html=True)
st.dataframe(df.set_index(df.columns[0]))


# SHOWING SOME INTERACTIVE TOOLS

st.write("---")
st.subheader('Which regions in the Netherlands would you like to analyze?')


# Province selection - Create dropdown menu for province selection
prov_list = df['Province'].unique().tolist()
prov_selection = st.multiselect('Select provinces:',
                                prov_list, #lista de valores
                                ['Noord-Holland','Utrecht']) #valores predeterminados


# Job title - Create slider for year range selection
job_list = df['Job Title'].unique().tolist()
analyst_list = df[df['Job Title'].str.contains('Analyst', case=False, na=False)]['Job Title'].unique().tolist()
job_selection = st.multiselect('Select job title:',
                               job_list, #lista de valores
                              analyst_list) #valores predeterminados

# Subset data - Perform changes on dataframe
df_selection = df[
    df['Province'].isin(prov_selection) & df['Job Title'].isin(job_selection)
]

# Extract year from 'Hiredate' for trend analysis
df_selection['Hire Year'] = pd.to_datetime(df_selection['Hiredate']).dt.year

# Reshape the data with a pivot table, aggregating salaries by job title and hire year
reshaped_df = df_selection.pivot_table(
    index='Hire Year',
    columns='Job Title',
    values='Salary',
    aggfunc='sum',
    fill_value=0
).reset_index()

# Data preparation for charting
df_chart = pd.melt(reshaped_df, id_vars='Hire Year', var_name='Job Title', value_name='Salary')

# Display salary over time by job title line chart
chart = alt.Chart(df_chart).mark_line().encode(
    x=alt.X('Hire Year:O', title='Hire Year'),
    y=alt.Y('Salary:Q', title='Total Salary ($)', axis=alt.Axis(format='$~s')),
    color='Job Title:N'
).properties(height=320)

# Convert columns with date types to DD/MM/AAAA
for col in df_selection.select_dtypes(include=['datetime', 'object']):
    try:
        # Convert to datetime format
        df_selection[col] = pd.to_datetime(df[col])
        # Format as DD/MM/YYYY
        df_selection[col] = df_selection[col].dt.strftime('%d/%m/%Y')
    except ValueError:
        # Skip columns that are not actually dates
        continue

# Display the table and chart in Streamlit
st.dataframe(df_selection.set_index(df_selection.columns[0]))
st.altair_chart(chart, use_container_width=True)


option = st.selectbox("TABLEAU or Profile Report (PR)",("Tableau", "PR"))

if option == "Tableau":
    st.markdown("Click → [TABLEAU](https://public.tableau.com/views/IncentroInterview/HRSummary?:language=es-ES&publish=yes&:sid=&:redirect=auth&:display_count=n&:origin=viz_share_link)")


elif option == "PR":
    pr = ProfileReport(df,explorative=True)
    st.header("**Profiling Report**")
    st.info("""It provides a comprehensive overview of the HR dataset,
            highlighting key statistics, distributions, and correlations among variables.
            \nIt helps identify data quality issues, trends, and patterns,
            making it easier to understand and analyze the data before further processing.
            """)
    st_profile_report(pr) #automático

else:
    # Generate random points around Amsterdam
    amsterdam_points = pd.DataFrame(
        np.random.randn(500, 2) / [50, 50] + [52.3676, 4.9041],
        columns=["lat", "lon"],
    )

    # Generate random points around Utrecht
    utrecht_points = pd.DataFrame(
        np.random.randn(500, 2) / [50, 50] + [52.0907, 5.1214],
        columns=["lat", "lon"],
    )

    # Combine both sets of points
    df = pd.concat([amsterdam_points, utrecht_points], ignore_index=True)

    # Display map centered around the Netherlands
    st.map(df)

# TABLEAU LINK
#https://public.tableau.com/views/Incentro_Interview/HRSummary?:language=es-ES&publish=yes&:sid=&:redirect=auth&:display_count=n&:origin=viz_share_link


# SIDEBAR
st.sidebar.write("---")
st.sidebar.header("Used tools:")


st.sidebar.markdown(
    '''
    <a href="https://github.com/marinasb28/ResponsivePortfolio/tree/main/TABLEAU" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://upload.wikimedia.org/wikipedia/commons/9/91/Octicons-mark-github.svg" alt="GitHub Logo" width="20" style="vertical-align:middle; margin-right:5px; border: 2px solid black; border-radius: 50%;">
        Github Repository
    </a>
    ''',
    unsafe_allow_html=True
)


st.sidebar.write("")
st.sidebar.markdown(
    '''
    <a href="https://public.tableau.com/views/IncentroInterview/HRSummary?:language=es-ES&publish=yes&:sid=&:redirect=auth&:display_count=n&:origin=viz_share_link" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://cdn.worldvectorlogo.com/logos/tableau-software.svg" alt="Tableau Logo" width="20" style="vertical-align:middle; margin-right:5px;">
        Tableau Dashboard
    </a>
    ''',
    unsafe_allow_html=True
)