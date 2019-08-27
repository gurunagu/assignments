*** Settings ***
Documentation    this file contains the login file resource

Library    SeleniumLibrary  

*** Variables ***
${url}     https://opensource-demo.orangehrmlive.com/index.php/auth/login 
${browser}    gc
${loginpage_locator}    css = div[id='logInPanelHeading']
${username_locator}     css = input[name='txtUsername']
${password_locator}     css = input[name='txtPassword']
${username}    Admin
${password}    admin123
${signin_button_locator}    css = [name='Submit']
${loggedin_page_locator}    css = [id='welcome']


*** Keywords ***
Print 
    
    [Arguments]    ${message}
    Log    \n${message}\n
    Log To Console    \n${message}\n
    
Open Brower And Open Page
    
    Open Browser    ${url}    ${browser}
    Maximize Browser Window  
    
Verify The Login Page
    Wait Until Element Is Visible    ${loginpage_locator} 
    Page Should Contain Element    ${loginpage_locator} 
    
Enter Username
    Wait Until Element Is Visible    ${username_locator}
    Click Element    ${username_locator}
    Clear Element Text    ${username_locator}
    Input Text    ${username_locator}    ${username}
    
Enter Password
    Wait Until Element Is Visible    ${password_locator}
    Click Element    ${password_locator}
    Clear Element Text    ${password_locator}
    Input Text    ${password_locator}    ${password}
    
click on signin button
    Wait Until Element Is Visible    ${signin_button_locator}
    Click Element    ${signin_button_locator}     
     
Verify Logged In Page   
    ${message}    Element Should Be Visible    ${loggedin_page_locator}     
    Run Keyword If    ${message} == None    Print     Valid Login
    ...    ELSE    Print    Login failed            
      
close the browser
    sleep     3s
    close browser
    
    