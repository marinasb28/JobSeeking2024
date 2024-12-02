import streamlit as st
from pathlib import Path
from streamlit_option_menu import option_menu
import requests


# 1_🏘️_Home
# 2_👩🏾‍🎓_About
# 3_📊_Tableau
# 4_🔮_Prediction
# 9_📧_Contact
# GENERAL SETTINGS
PAGE_TITLE = "Digital CV | Marina Suárez Blázquez"
PAGE_ICON = ":briefcase:"
DESCRIPTION = """
NOTE: Junior data analyst, just starting her career.
"""
EMAIL = "msuarezblazquez@gmail.com"
SOCIAL_MEDIA = {
    "LinkedIn": "https://www.linkedin.com/in/marina-su%C3%A1rez-bl%C3%A1zquez-a4aa301bb/",
    "GitHub": "https://github.com/marinasb28"
}
LOGOS = {
    "LinkedIn": '<i class="fa-brands fa-linkedin"></i>',
    "GitHub": '<i class="fa-brands fa-github"></i>'
}

# ---- PATH SETTINGS --- #

# FILES
current_dir = Path(__file__).parent if "__file__" in locals() else Path.cwd()
css_file = current_dir / "styles" / "main.css"

# PICTURES
resume_file = current_dir / "assets" / "Resume_CV.pdf"
profile_pic = current_dir / "assets" / "cap.jpg"

# PAGES
home = current_dir /"pages"/"1_🏘️_Home.py"
about_me = current_dir /"pages"/"2_👩🏾‍🎓_About.py"
tableau_pg = current_dir/"pages"/"3_📊_Tableau.py"
prediction_pg = current_dir/"pages"/"4_🔮_Prediction.py"
contact_me = current_dir /"pages"/"5_📧_Contact.py"

# DATA
hr_records = current_dir.parent/"TABLEAU"/"HR_data.csv"
pred_data = current_dir/"data"/"survey_results_public.csv"
pkl_s = current_dir/"data"/"salary_pred_model.pkl"
# FUNCTIONS

# Load animations
def load_animation(url):
    r = requests.get(url)
    if r.status_code != 200:
        return None
    return r.json()

# HOME FILE
def run_home():
    with open(home) as f:
        exec(f.read(), {'__name__': '__main__'})


# ABOUT ME FILE

def run_about_me():
    with open(about_me) as f:
        exec(f.read(), {'__name__': '__main__'})

# CONTACT FILE
def run_contact_me():
    with open(contact_me) as f:
        exec(f.read(), {'__name__': '__main__'})

# TABLEAU
def run_tableau():
    with open(tableau_pg) as f:
        exec(f.read(), {'__name__': '__main__'})

# PREDICTION
def run_prediction():
    with open(prediction_pg) as f:
        exec(f.read(), {'__name__': '__main__'})


# MAIN FUNCTION
def main():
    st.set_page_config(
        page_title="Digital CV | MSB",
        page_icon=PAGE_ICON
    )

    if 'page' not in st.session_state:
        st.session_state.page = 'Home'  # Default page is Home

    # Define the options
    options = ["Home", "About me", "Tableau", "Prediction", "Contact"]
    icons = ["house", "person-lines-fill", "bar-chart", "cookie", "envelope-at"]

    # Display the option menu
    selected = option_menu(
        menu_title=None,
        options=options,
        icons=icons,
        menu_icon="cast",
        default_index=options.index(st.session_state.page),  # Sets default to session state's page
        orientation="horizontal",
        styles={
            "container": {
                "display": "flex",
                "justify-content": "center",
                "align-items": "center",
                "width": "100%",
                "padding": "0",
            },
            "icon": {
                "color": "black",
                "font-size": "20px",  # Adjust font size
                "display": "inline-block",
            },
            "nav-link": {
                "font-size": "20px",  # Adjust font size for the text
                "text-align": "center",
                "margin": "0 5px",  # Adjust margin for spacing
                "--hover-color": "#82C7DE",
                "padding": "10px",  # Uniform padding for links
                "display": "flex",
                "align-items": "center",
                "white-space": "nowrap",  # Prevent text wrapping
            },
            "nav-link-selected": {
                "background-color": "#82C7DE",
                "color": "white",
                "margin": "0 5px",  # Same margin as other links
            }
        }
    )
    
    # Update session state based on selection
    if selected:
        st.session_state.page = selected

    # Navigate to the correct page based on the selection
    if st.session_state.page == "About me":
        run_about_me()
    elif st.session_state.page == "Contact":
        run_contact_me()
    elif st.session_state.page == "Home":
        run_home()
    elif st.session_state.page == "Tableau":
        run_tableau()
    elif st.session_state.page == "Prediction":
        run_prediction()




if __name__ == "__main__":
    main()