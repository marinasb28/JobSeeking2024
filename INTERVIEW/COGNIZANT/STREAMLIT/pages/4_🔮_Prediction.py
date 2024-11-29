import streamlit as st
import pandas as pd
import pickle
import matplotlib.pyplot as plt
import numpy as np
import INTERVIEW.COGNIZANT.STREAMLIT.main_cognizant as mp

if not st.session_state.page == "Prediction":
    st.set_page_config(
    page_title="Princing Prediction",
    page_icon="🔮"
    )


# SIDEBAR menu
st.sidebar.title("Pages")
st.sidebar.page_link(mp.home,label="Home",icon="🏘️")
st.sidebar.page_link(mp.about_me,label="About me",icon="👩🏾‍🎓")
st.sidebar.page_link(mp.tableau_pg,label="Tableau",icon="📊")
st.sidebar.page_link(mp.prediction_pg,label="Prediction",icon="🔮")
st.sidebar.page_link(mp.contact_me,label="Contact me",icon="📧")

# -- FUNCTIONS ------- #


# Simplifica la impresión de los números
def format_number(num):
    if num >= 1_000_000:
        return f"{num / 1_000_000:.1f}M"
    elif num >= 1_000:
        return f"{num / 1_000:.1f}K"
    else:
        return str(num)

# Nos ayuda a deshacernos de aquellos países con pocos datos
def cut_cat(category_data, threshold):
    category_mapping = {}
    for idx in range(len(category_data)):
        if category_data.values[idx] >= threshold:
            category_mapping[category_data.index[idx]] = category_data.index[idx]
        else:  # if insufficient data, categorize as "Other"
            category_mapping[category_data.index[idx]] = 'Other'
    return category_mapping

# Simplifica las strings
def short_ed(x):
    if 'Bachelor’s degree' in x:
        return 'Bachelor’s degree'
    if 'Master’s degree' in x:
        return 'Master’s degree'
    if 'Professional degree' in x or 'Other doctoral' in x:
        return 'Post grad'
    return 'Less than a Bachelors'

#@st.cache_data
def load_csv():

    df = pd.read_csv(mp.pred_data)

    keep = ["Country", "EdLevel", "YearsCodePro", "Employment", "ConvertedCompYearly"]
    df = df[keep]

    df = df = df.dropna(subset=['ConvertedCompYearly'])
    df = df.dropna()
    df = df[df["Employment"].str.contains("full-time", case=False, na=False)]
    df = df.drop("Employment", axis=1)


    country_map = cut_cat(df['Country'].value_counts(), 400)
    df["Country"] = df["Country"].map(country_map)
    df = df[df["ConvertedCompYearly"] <= 250000]
    df = df[df["ConvertedCompYearly"] >= 10000]
    df = df[df["Country"] != "Other"]

    df['YearsCodePro'] = df['YearsCodePro'].apply(lambda x: 0.5 if x == 'Less than 1 year' else float(x))
    df["EdLevel"] = df["EdLevel"].apply(short_ed)
    df = df.rename({"ConvertedCompYearly": "Salary"}, axis=1)
    
    return df


# Load the trained model
def load_model():
    with open(mp.pkl_s, 'rb') as file:
        data = pickle.load(file)
    return data


# -- MAIN FUNCTIONS -- #
def show_predict():
    st.title("Software Developer Salary Prediction 💲")
    st.warning("We need some information to predict the salary.")
    data = load_model()

    regressor = data["model"]
    le_country = data["le_country"]
    le_ed = data["le_education"]

    # get country selector
    country_list = (
        "United States of America",
        "United Kingdom of Great Britain and Northern Ireland",
        "France",
        "Brazil",
        "Germany",
        "Ukraine",
        "Canada",
        "Italy",
        "India",
        "Spain",
        "Netherlands",
        "Sweden",
        "Poland",
        "Australia"
    )

    # get education selector
    ed_list = (
        "Less than a Bachelors",
        "Post grad",
        "Master’s degree",
        "Bachelor’s degree"
    )


    # FEATURES
    country_selection = st.selectbox("**Country**", country_list)
    ed_selection = st.selectbox("**Education level**", ed_list)
    exp_years = st.slider("**Years of experience:**",0,50,3)

    # Start prediction
    on = st.toggle("Turn on to predict the salary 💸")


    if on:
        X = np.array([[country_selection, ed_selection, exp_years ]])
        X[:, 0] = le_country.transform(X[:,0])
        X[:, 1] = le_ed.transform(X[:,1])
        X = X.astype(float)

        salary = regressor.predict(X)
        st.success(f"Predicted salary: ${format_number(salary[0])}")

def show_explore():
    st.title("Exploring Software Developer Salary 💲")

    df = load_csv()
    data = df["Country"].value_counts()

    fig1, ax1 = plt.subplots()
    ax1.pie(data, labels=data.index, autopct="%1.1f%%", shadow=True, startangle=90)
    ax1.axis("equal")  # Equal aspect ratio ensures that pie is drawn as a circle.

    st.write("""#### Number of Data from different countries""")

    st.pyplot(fig1)
    
    st.write(
        """
    #### Mean Salary Based On Country
    """
    )

    data = df.groupby(["Country"])["Salary"].mean().sort_values(ascending=True)
    st.bar_chart(data)

    st.write(
        """
    #### Mean Salary Based On Experience
    """
    )

    data = df.groupby(["YearsCodePro"])["Salary"].mean().sort_values(ascending=True)
    st.line_chart(data)


# -- MAIN CODE -- #
st.sidebar.write("---")
st.sidebar.title("Prediction 🔮")
page = st.sidebar.selectbox("Explore or predict?",("Explore", "Predict"))

if page == "Predict":
    show_predict() 


elif page == "Explore":
    show_explore()

else:
    st.title("Old Prediction Project 🔮")
    st.write("Hola")
