*** Settings ***
Documentation     this file contains the login file resource   

Resource    login_assignment_libraries.robot

*** Keywords ***
Print 
    
    [Arguments]    ${message}
    Log    \n${message}\n
    Log To Console    \n${message}\n
    
Element click
    [Arguments]    
    ...    ${locator}
    Wait Until Element Is Visible    ${locator}
    Click Element                    ${locator}  
    
Open Brower And Open Page
    
    Open Browser                     ${url}    ${browser}
    Maximize Browser Window  
    
Verify The Login Page
    Wait Until Element Is Visible    ${loginpage_locator} 
    Page Should Contain Element      ${loginpage_locator} 
    
Enter Username
    Element click         ${username_locator}
    Clear Element Text    ${username_locator}
    Input Text            ${username_locator}    ${username}
    
Enter Password
    Element click         ${password_locator}
    Clear Element Text    ${password_locator}
    Input Text            ${password_locator}    ${password}
    
click on signin button
    Element click    ${signin_button_locator}     
     
Verify Logged In Page   
    ${message}    Run Keyword And Return Status    Element Should Be Visible    ${Welcome_admin_locator}     
    Run Keyword If    ${message} == True    Print     Valid Login
    ...    ELSE    Print    Login failed    

Logout
    Element click                    ${Welcome_admin_locator}
    Element click                    ${logout_locator}
    Verify The Login Page
                   
      
close the browser
    sleep     3s
    close browser
    
    