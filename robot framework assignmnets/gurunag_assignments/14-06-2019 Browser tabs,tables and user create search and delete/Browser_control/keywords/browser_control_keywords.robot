*** Settings ***
Documentation    this file contains the keywords used in the project
    
Resource    ../variables/browser_control_variables.robot

*** Keywords ***

Open The Browser
    Open Browser    ${url}   ${browser}
    Maximize Browser Window
    Set Browser Implicit Wait    5s
    
Home Page verification
    Select Window                    ${page_title}
    Wait Until Element Is Visible    ${page_verify_locator}

Element Click
    [Arguments]    ${loc}
    Wait Until Element Is Visible    ${loc}
    Element Should Be Visible        ${loc}
    Click Element                    ${loc}    

New Browser Window
    Wait Until Element Is Visible    ${page_verify_locator}    
    Element Click                    ${new_window_locator}      
    Select Window                    ${new_window_title}
    Maximize Browser Window
    Element Should Be Visible        ${new_window_verify_loc}    
    
New Message Window
    Home Page verification
    Element Click                    ${new_msg_window_loc} 
    Select Window                    NEW
    Element Should Be Visible        ${new_msg_window_verify_loc}  
    
New Tab Window 
    Home Page verification    
    Element Click                    ${new_tab_locator}      
    Select Window                    ${new_window_title}
    Element Should Be Visible        ${new_window_verify_loc}
    
Handle The Alert
    Home Page verification    
    Element Click                    ${alert_locator} 
    sleep                            2s
    # using sleep to see the alert
    Alert Should Be Present          ${alert text} 
    
Link Text Window
    Home Page verification
    Element Click                 ${link_text_locator}    
    Select Window                 ${new_window_title}
    Element Should Be Visible     ${new_window_verify_loc}
       

Close The Browser
    sleep    5s
    close browser
