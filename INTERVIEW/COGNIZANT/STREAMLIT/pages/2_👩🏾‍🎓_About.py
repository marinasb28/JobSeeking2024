import streamlit as st
from streamlit_lottie import st_lottie
import main as mp

if not st.session_state.page == "About me":
    st.set_page_config(
    page_title="About me",
    page_icon="🪞"
    )


# SIDEBAR menu
st.sidebar.title("Pages")
st.sidebar.page_link(mp.home,label="Home",icon="🏘️")
st.sidebar.page_link(mp.about_me,label="About me",icon="👩🏾‍🎓")
st.sidebar.page_link(mp.tableau_pg,label="Tableau",icon="📊")
st.sidebar.page_link(mp.prediction_pg,label="Prediction",icon="🔮")
st.sidebar.page_link(mp.contact_me,label="Contact me",icon="📧")




animations_url = [
    "https://lottie.host/1880989a-280b-45bf-bd99-a7f92be6e223/TknwiHOHc4.json", # university
    "https://lottie.host/a433bd08-e3aa-4d6e-bbfa-dc4cb9a629c2/eoBdchhxSP.json"# experience
]
university = mp.load_animation(animations_url[0])
experience = mp.load_animation(animations_url[1])

st.title("Marina Suárez Blázquez")
st.write("---")

with st.container():
    # NOTE: modificar why am I here
    col1, col2 = st.columns(2)
    with col1:
        st.subheader("""
        About me
        - Who am I?
            - July 28,2001 | Extremadura, Spain 🇪🇸        
        - How am I ?
            - Hardworking, stubborn & patient
        - Why am I here? 🇳🇱
            - Culture, language, goals...
        """)
    with col2:
        st.image(str(mp.profile_pic))

    st.write("---")

with st.container():
    col3,col4 =  st.columns(2)
    with col3:
        if university:
            st_lottie(university)
    with col4:
        st.subheader("""
        Education
        - I.E.S Cuatro Caminos | 2013 - 2019
            - Science & Technology
        - Fairborn High School 🇺🇸 | 2016-2017
            - Computer Science
        - Universitat Pompeu Fabra | 2019 - 2024
            - Bachelor of Mathematical Engineering in Data Science
        """)
    st.write("---")
with st.container():
    col5,col6 = st.columns(2)
    with col5:
        st.subheader("Experience")
        st.markdown("""
            - <a href="https://www.blowww.io/home-en" style="color: black; text-decoration: none;" onmouseover="this.style.color='blue'; this.style.textDecoration='underline'" onmouseout="this.style.color='black'; this.style.textDecoration='none'">Blowww 4 Analytics</a>
                - Intern data migration | July 2022 - Dec 2022
                    <br>
                    <br>
            - <a href="https://uvesolutions.com/" style="color: black; text-decoration: none;" onmouseover="this.style.color='blue'; this.style.textDecoration='underline'" onmouseout="this.style.color='black'; this.style.textDecoration='none'">UVE Solutions</a>
                - Intern consultant | May 2023 - Jul 2023
                - Junior consultant | Jul 2023 - Jan 2024
                - IT consultant, member of Operation team | Jan 2024 - Jul 2024
            """, unsafe_allow_html=True)
    with col6:
        st_lottie(experience)
    
    st.markdown("""
        **Learned Tools:**

        - **Data Analysis:** Microsoft Excel (including KPI development)
        - **Database Management:** MySQL, PostgreSQL, and DBeaver
        - **Soft Skills:** Effective stress handling
    """)
    st.info("Why am I here? 🇳🇱")
    st.write("---")

# NOTE: modificar skills según empresa

with st.container():
    st.title("Skills")    
    col7, col8 = st.columns(2)    

    with col7:
        st.subheader("Programming 👩🏾‍💻:")
        languages = {
            "C/C#": 50,
            "Matlab": 65,
            "Python": 80,
            "SQL": 85
        }
        
        # Sort languages by progress in ascending order
        for lang, progress in sorted(languages.items(), key=lambda item: item[1]):
            st.write(f"{lang}")
            st.progress(progress)

    with col8:
        st.subheader("Data Visualization 📊:")
        tools = {
            "PowerBI": 50,
            "Excel": 80,
            "Tableau": 90
        }
        
        # Sort tools by progress in ascending order
        for tool, progress in sorted(tools.items(), key=lambda item: item[1]):
            st.write(f"{tool}")
            st.progress(progress)

        # NOTE: Tableau
        st.page_link(mp.tableau_pg, label="Dashboard", icon="📊",
                     help="Human Resources Tool", use_container_width=True)



with st.container():
    col9, col10 = st.columns(2)
    
    with col9:
        st.subheader("Languages:")
        languages = {
            "Spanish": 100,
            "English": 85,
            "Catalan": 55
        }

        # Sort languages by progress in ascending order
        for lang, progress in sorted(languages.items(), key=lambda item: item[1]):
            st.write(lang)
            st.progress(progress)
        
    with col10:
        st.subheader("Soft skills:")
        st.markdown("""
            - Rapid adaptability
            - Observant, analytical
            - Problem-solving
            - Teamwork
        """)



# SIDEBAR
st.sidebar.divider()
st.sidebar.header("Where can you find me?")
st.sidebar.markdown(
    '''
    <a href="https://www.linkedin.com/in/marina-su%C3%A1rez-bl%C3%A1zquez-a4aa301bb/" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://upload.wikimedia.org/wikipedia/commons/c/ca/LinkedIn_logo_initials.png" alt="LinkedIn" width="20" style="vertical-align:middle; margin-right:5px;">
        LinkedIn
    </a>
    ''',
    unsafe_allow_html=True
)
st.sidebar.write("")
st.sidebar.markdown(
    '''
    <a href="https://www.upf.edu/web/etic/home/-/asset_publisher/nT5ucm2DcHyd/content/marina-su%C3%A1rez-gemcd-i-albert-domingo-upf-ventures-participen-en-l-%C3%80gora-experts-de-telef%C3%B3nica/maximized" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://media.licdn.com/dms/image/v2/C510BAQGKUPI03WP6vA/company-logo_200_200/company-logo_200_200/0/1631349983274?e=1738195200&v=beta&t=3sbVlpRVGlWfxV03H7kNU4NTIHqh0pBRpavF3PLEQwc" alt="Telefónica Logo" width="20" style="vertical-align:middle; margin-right:5px;">
        Telefónica Experts Agora
    </a>
    ''',
    unsafe_allow_html=True
)

st.sidebar.write("")
st.sidebar.markdown(
    '''
    <a href="https://www.linkedin.com/posts/marina-su%C3%A1rez-bl%C3%A1zquez-a4aa301bb_oppenheimers-legacy-ai-era-in-worlds-digital-activity-7256990848184111104-feNg?utm_source=share&utm_medium=member_desktop" target="_blank" style="font-size:17px; text-decoration: none; color: black;">
        <img src="https://media.licdn.com/dms/image/v2/C510BAQGKUPI03WP6vA/company-logo_200_200/company-logo_200_200/0/1631349983274?e=1738195200&v=beta&t=3sbVlpRVGlWfxV03H7kNU4NTIHqh0pBRpavF3PLEQwc" alt="Telefónica Logo" width="20" style="vertical-align:middle; margin-right:5px;">
        Final Degree Thesis
    </a>
    ''',
    unsafe_allow_html=True
)