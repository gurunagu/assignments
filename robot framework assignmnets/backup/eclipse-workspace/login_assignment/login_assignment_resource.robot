*** Settings ***
Documentation     this file contains the login file resource   

Resource    login_assignment_libraries.robot

*** Keywords ***
Print 
    
    [Arguments]        
    ...                 ${message}
    Log               \n${message}\n
    Log To Console    \n${message}\n
    
Click On Element
    [Arguments]    
    ...    ${locator}
    Wait Until Element Is Visible    ${locator}
    Click Element                    ${locator}  
    
Open Brower And Open Page
    
    Open Browser                     ${url}    ${browser}
    Maximize Browser Window  
    Set Browser Implicit Wait        ${timeout}
    
Verify The Login Page
    Wait Until Element Is Visible    ${loginpage_locator} 
    Page Should Contain Element      ${loginpage_locator} 
    
Enter Username
    Click On Element         ${username_locator}
    Clear Element Text    ${username_locator}
    Input Text            ${username_locator}    ${username}
    
Enter Password
    Click On Element         ${password_locator}
    Clear Element Text    ${password_locator}
    Input Text            ${password_locator}    ${password}
    
click on signin button
    Click On Element    ${signin_button_locator}     
     
Verify Logged In Page   
    ${message}    Run Keyword And Return Status    Element Should Be Visible    ${Welcome_admin_locator}     
    Run Keyword If    ${message} == True    Print     Valid Login
    ...    ELSE    Print    Login failed    

Logout
    Click On Element                    ${Welcome_admin_locator}
    Click On Element                    ${logout_locator}
    Verify The Login Page
                   
      
close the browser
    Sleep             ${timeout}
    close browser
    
    