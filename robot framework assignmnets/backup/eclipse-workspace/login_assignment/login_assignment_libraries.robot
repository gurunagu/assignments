*** Settings ***
Documentation    this file contains the libraries and variables used in the project

Library    SeleniumLibrary  

*** Variables ***
${url}                      https://opensource-demo.orangehrmlive.com/index.php/auth/login 
${browser}                  gc
${timeout}                  10s
${loginpage_locator}        css = div[id='logInPanelHeading']
${username_locator}         css = input[name='txtUsername']
${password_locator}         css = input[name='txtPassword']
${username}                 Admin
${password}                 admin123
${signin_button_locator}    css = [name='Submit']
${Welcome_admin_locator}    css = [id='welcome']
${logout_locator}           xpath = //div[@id='welcome-menu']//li[2]/a