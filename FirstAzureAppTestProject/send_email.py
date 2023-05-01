import smtplib, ssl
import os


port = 465
smtp_server = "smtp.gmail.com"
USERNAME = os.environ.get('jawaria2525@gmail.com')
PASSWORD = os.environ.get('jawariA##12##34')
message = """\
Subject: GitHub Email Report

This is your daily email report.
"""

context = ssl.create_default_context()
with smtplib.SMTP_SSL(smtp_server, port, context=context) as server:
    server.login(USERNAME,PASSWORD)
    server.sendmail(USERNAME,USERNAME,message)
