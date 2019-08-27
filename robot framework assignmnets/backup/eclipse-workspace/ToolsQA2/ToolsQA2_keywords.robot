*** Settings ***
Resource    ToolsQA2_libraries.robot

*** Keywords ***
Print 
    [Arguments]        ${message}
    Log                \n${message}\n
    Log To Console     \n${message}\n
    
Generate A Single Integer   
    [Arguments]    
    ...    ${random}
    ${num}    Generate Random String    ${length}    ${random}
    [return]       ${num} 
    
Open The Browser
    Open Browser    ${url}    ${browser}
    Maximize Browser Window
    
Verify Page Open
    Wait Until Element Is Visible    ${pagetest_locator}     10s
    Page Should Contain Element      ${pagetest_locator}
    
Text Input
    [Arguments]    
    ...        ${locator}
    ...        ${value}
    Wait Until Element Is Visible    ${locator}
    Click Element                    ${locator} 
    Clear Element Text               ${locator}
    Input Text                       ${locator}    ${value}
    
Select Male Radio Button
    Wait Until Element Is Visible                 ${exp_radio_locator}   
    Select Radio Button                           ${exp_radio_value}      ${index}  
    ${result}    Run Keyword And Return Status    
    ...    Radio Button Should Not Be Selected    ${exp_radio_locator}
    Run Keyword If    ${result} == True     Print     radio button not selected    
    ...    ELSE    Print    radio button selected
    ...    
Automation Tester Checkbox
    Wait Until Element Is Visible    ${Automation_tester_loc}
    Select Checkbox                  ${Automation_tester_loc}    
    Checkbox Should Be Selected      ${Automation_tester_loc}
    
Selenium Commands Selector
    Wait Until Element Is Visible          ${selenium_cmd_locator} 
    ${num}    Generate A Single Integer    ${random_0-4}
    Select From List By Index              ${selenium_cmd_locator}    ${num}  
    
Profile Pic Selector  
    Choose File    ${pic_upload_locator}      ${pic_location} 
    
    
    
    
    
  
   