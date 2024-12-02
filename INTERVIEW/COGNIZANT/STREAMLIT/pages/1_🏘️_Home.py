import streamlit as st
from datetime import datetime
import time
import streamlit.components.v1 as components
import main_cognizant as mp


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

# COGNIZANT VIDEO

# Progress bar - COUNTDOWN
my_bar,vid = st.progress(0),False
status_text = st.empty()
for i in range(101):
    time.sleep(0.07)
    status_text.text(f"{i}%")
    my_bar.progress(i)
vid = True

# NOTE: modificar vídeo, colores, role
if vid:
    status_text.markdown(
        '''
        <div style="text-align: center; width: 100%;">
            <h3>...you still looking for the right 
                <a href="https://careers.cognizant.com/global-en/jobs/?keyword=&location=Amsterdam%2C+Netherlands&radius=100&lat=52.3675734&lng=4.9041389&cname=Netherlands&ccode=NL&pagesize=10#results"
                style="color:#248D95" target="_blank">
                    PRODUCTION SUPPORT ANALYST
                </a>?
            </h3>
        </div>
        ''',
        unsafe_allow_html=True
    )

    # HTML and JavaScript for the embedded video, centered responsively
    html_code = """
        <div style="position: relative; width: 100%; padding-bottom: 56.25%; /* Aspect ratio 16:9 */">
            <iframe 
                id="video_player" 
                src="https://www.youtube.com/embed/mIv6YAydrZw?autoplay=1&mute=1&rel=0&controls=0" 
                frameborder="0" 
                allow="autoplay; encrypted-media" 
                allowfullscreen
                style="position: absolute; top: 0; left: 0; width: 100%; height: 100%;">
            </iframe>
        </div>
        """


    # Render the HTML code
    components.html(html_code, height=400)
time.sleep(1)


#NOTE: modify core & values
st.markdown('<h2 style="text-align: center;">Work as one</h2>', unsafe_allow_html=True)
time.sleep(0.75)

st.markdown('<h2 style="text-align: center; color: #000048;">Raise the bar</h2>', unsafe_allow_html=True)
time.sleep(0.75)

st.markdown('<h2 style="text-align: center; color: #248D95;">Do the right thing</h2>', unsafe_allow_html=True)
time.sleep(0.75)

# Display the final message
st.markdown('<h2 style="text-align: center; color: #82C7DE">Own it</h2>', unsafe_allow_html=True)


# SIDEBAR
st.sidebar.divider()
st.sidebar.header("Cognizants's Info")

#NOTE: cambiar logos y links
st.sidebar.markdown(
    '''
    <a href="https://www.cognizant.com/nl/en" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://media.licdn.com/dms/image/v2/D4E0BAQHjkUYrDIUKYA/company-logo_200_200/company-logo_200_200/0/1719839886088/cognizant_logo?e=1741219200&v=beta&t=WcOI8tNWFL49wujBg-Hw-a1kX1OP2LkAM9zjVctuf1Q" alt="Cognizant Logo" width="20" style="vertical-align:middle; margin-right:5px; border-radius: 50%;">
        Cognizant's Page
    </a>
    ''',
    unsafe_allow_html=True
)
st.sidebar.write("")
st.sidebar.markdown(
    '''
    <a href="https://careers.cognizant.com/global-en/" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://media.licdn.com/dms/image/v2/D4E0BAQHjkUYrDIUKYA/company-logo_200_200/company-logo_200_200/0/1719839886088/cognizant_logo?e=1741219200&v=beta&t=WcOI8tNWFL49wujBg-Hw-a1kX1OP2LkAM9zjVctuf1Q" alt="Cognizant Logo" width="20" style="vertical-align:middle; margin-right:5px; border-radius: 50%;">
        Vacancies
    </a>
    ''',
    unsafe_allow_html=True
)
st.sidebar.write("")
st.sidebar.markdown(
    '''
    <a href="https://www.linkedin.com/company/cognizant/posts/?feedView=all" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://upload.wikimedia.org/wikipedia/commons/c/ca/LinkedIn_logo_initials.png" alt="LinkedIn" width="20" style="vertical-align:middle; margin-right:5px;">
        LinkedIn
    </a>
    ''',
    unsafe_allow_html=True
)