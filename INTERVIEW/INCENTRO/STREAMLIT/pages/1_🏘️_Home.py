import streamlit as st
from datetime import datetime
import time
import streamlit.components.v1 as components
import main_incentro as mp


if not st.session_state.page == "Home":
    st.set_page_config(
    page_title="Home",
    page_icon="🏘️"
)

# SIDEBAR menu
st.sidebar.title("Pages")
st.sidebar.page_link(mp.home,label="Home",icon="🏘️")
st.sidebar.page_link(mp.about_me,label="About me",icon="👩🏾‍🎓")
st.sidebar.page_link(mp.tableau_pg,label="Tableau",icon="📊")
st.sidebar.page_link(mp.prediction_pg,label="Prediction",icon="🔮")
st.sidebar.page_link(mp.contact_me,label="Contact me",icon="📧")



# Get the current date and time
now = datetime.now()
current_date = now.strftime("%A, %B %d, %Y")

# Determine the greeting based on the current hour
current_hour = now.hour
if 5 <= current_hour < 12:
    greeting = "Good Morning! ☀️"
elif 12 <= current_hour < 18:
    greeting = "Good Afternoon! 🙋🏾‍♀️"
else:
    greeting = "Good Evening! ☕️"

# Display the greeting and the current date
st.title(greeting)
st.subheader(f"It's {current_date} and...")

# INCENTRO VIDEO

# Progress bar - COUNTDOWN
my_bar,vid = st.progress(0),False
status_text = st.empty()
for i in range(101):
    time.sleep(0.07)
    status_text.text(f"{i}%")
    my_bar.progress(i)
vid = True

# NOTE: modificar vídeo
if vid:
    status_text.markdown(
        '''
        <div style="text-align: center; width: 100%;">
            <h3>...you still looking for the right 
                <a href="https://careers.incentro.com/en/vacancy/data-analist" style="color:orange" target="_blank">
                    DATA ANALYST
                </a>?
            </h3>
        </div>
        ''',
        unsafe_allow_html=True
    )

    # HTML and JavaScript for the embedded video, centered responsively
    html_code = """
    <div style="display: flex; justify-content: center; width: 100%;">
        <iframe id="video_player" width="100%" height="315" 
            src="https://www.youtube.com/embed/6kiQeD6H4IE?autoplay=1&mute=1" 
            frameborder="0" allow="autoplay; encrypted-media" allowfullscreen>
        </iframe>
    </div>
    """

    # Render the HTML code
    components.html(html_code, height=400)
time.sleep(1)


# VALUES
st.markdown('<h2 style="text-align: center;">Boldness</h2>', unsafe_allow_html=True)
time.sleep(0.75)

# Display the second message
st.markdown('<h2 style="text-align: center; color: orange;">Mastery</h2>', unsafe_allow_html=True)
time.sleep(0.75)

# Display the final message
st.markdown('<h2 style="text-align: center;">Autonomy</h2>', unsafe_allow_html=True)


# SIDEBAR
st.sidebar.divider()
st.sidebar.header("Incentro's Info")

st.sidebar.markdown(
    '''
    <a href="https://www.incentro.com/en" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://media.licdn.com/dms/image/v2/C4D0BAQEjGsZx6VLVvw/company-logo_200_200/company-logo_200_200/0/1637333962978/incentro_logo?e=1738195200&v=beta&t=VSbCijhM-A-bW7SQomNChsBgg9LQFIIsyyfhvtG1SsE" alt="Incentro Logo" width="20" style="vertical-align:middle; margin-right:5px; border-radius: 50%;">
        Incentro's Page
    </a>
    ''',
    unsafe_allow_html=True
)
st.sidebar.write("")
st.sidebar.markdown(
    '''
    <a href="https://careers.incentro.com/en/vacancies" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://media.licdn.com/dms/image/v2/C4D0BAQEjGsZx6VLVvw/company-logo_200_200/company-logo_200_200/0/1637333962978/incentro_logo?e=1738195200&v=beta&t=VSbCijhM-A-bW7SQomNChsBgg9LQFIIsyyfhvtG1SsE" alt="Incentro Logo" width="20" style="vertical-align:middle; margin-right:5px; border-radius: 50%;">
        Vacancies
    </a>
    ''',
    unsafe_allow_html=True
)
st.sidebar.write("")
st.sidebar.markdown(
    '''
    <a href="https://www.linkedin.com/company/incentro/?originalSubdomain=nl" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://upload.wikimedia.org/wikipedia/commons/c/ca/LinkedIn_logo_initials.png" alt="LinkedIn" width="20" style="vertical-align:middle; margin-right:5px;">
        LinkedIn
    </a>
    ''',
    unsafe_allow_html=True
)