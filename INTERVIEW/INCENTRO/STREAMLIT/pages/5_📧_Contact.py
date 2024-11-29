import streamlit as st
from streamlit_lottie import st_lottie
import main_incentro as mp
import time

if not st.session_state.page == "Contact":
    st.set_page_config(
    page_title="Contact me",
    page_icon="📧"
    )

# SIDEBAR menu
st.sidebar.title("Pages")
st.sidebar.page_link(mp.home,label="Home",icon="🏘️")
st.sidebar.page_link(mp.about_me,label="About me",icon="👩🏾‍🎓")
st.sidebar.page_link(mp.tableau_pg,label="Tableau",icon="📊")
st.sidebar.page_link(mp.prediction_pg,label="Prediction",icon="🔮")
st.sidebar.page_link(mp.contact_me,label="Contact me",icon="📧")

# FUNCIONES

# Use local CSS file
def local_css(file_name):
    with open(file_name) as f:
        st.markdown(f"<style>{f.read()}</style>", unsafe_allow_html=True)

# Bye bye function

def bye_msgt():
    # Display the first message
    st.markdown('<h2 style="text-align: center;">Thank You for Your Attention!</h2>', unsafe_allow_html=True)
    time.sleep(1.5)

    # Display the second message
    st.markdown('<h2 style="text-align: center;">If you have any questions or want to connect, feel free to reach out!</h2>', unsafe_allow_html=True)
    time.sleep(1.5)

    # Display the final message
    st.markdown('<h2 style="text-align: center;">Let’s collaborate and make great things happen!</h2>', unsafe_allow_html=True)
    time.sleep(1.5)

    # Display the final message
    st.markdown('<h2 style="text-align: center;">Let’s keep the conversation going! 👋🏾</h2>', unsafe_allow_html=True)
    time.sleep(1.5)

    # Countdown logic
    ph = st.empty()
    for secs in range(5, -1, -1):
        mm, ss = secs // 60, secs % 60
        ph.metric("Countdown", f"{mm:02d}:{ss:02d}")
        time.sleep(1)

    # Display balloons after countdown
    st.balloons()


st.title(":mailbox: Get In Touch With Me!")
details = ['msuarezblazquez@gmail.com', '5147aa1e881586fa2cf7cf939363504e']

# Contact form
contact_form = f"""
    <form action="https://formsubmit.co/{details[1]}" method="POST" id="contactForm">
        <input type="hidden" name="_captcha" value="false" />
        <input type="text" name="name" placeholder="Full Name" required>
        <input type="text" name="company" placeholder="Company Name">
        <input type="email" name="email" placeholder="Your email" required>
        <textarea name="message" placeholder="Your message here" required></textarea>
        <button type="submit">Send</button>
    </form>
"""
anim_name = "https://lottie.host/05d55e1e-a842-4016-a551-c06d35418bbb/Ub5CF8DIVy.json"
animation = mp.load_animation(anim_name)

left_col,right_col = st.columns((2,1))
with left_col:
    st.markdown(contact_form, unsafe_allow_html=True)
with right_col:
    st_lottie(animation)

# Load the CSS file if it exists
local_css(mp.css_file)

st.write("\n\n---")
if st.button("Done! ✅"):
    bye_msgt()