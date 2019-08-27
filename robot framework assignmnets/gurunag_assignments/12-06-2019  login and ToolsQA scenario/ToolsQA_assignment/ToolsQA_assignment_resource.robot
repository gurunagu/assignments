*** Settings ***
Documentation    this file contains the resources for testing of toolsqa website

Resource    ToolsQA_assignment_libraries.robot
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
    
Open Brower And Open Page
    
    Open Browser     ${url}    ${browser}
    Maximize Browser Window
    
Verify Practice Automation Form
    
    Wait Until Element Is Visible    ${verify_automationForm_locator}      
    Element Should Contain           ${verify_automationForm_locator}     ${text_to_be_located}    
    
Verify Link Test
    
    Click Element                       ${linktest_locator} 
    Wait Until Element Is Visible       ${linktestcheck_locator}
    ${result}    Run Keyword And Return Status     
    ...    Element Should Be Visible    ${linktestcheck_locator}  
    Run Keyword If    ${result} == True     Print    link test verified    
    ...    ELSE    Print    link test failed
    Go Back
      
Year Of Experience Radio Button   
    
    Wait Until Element Is Visible                 ${radiobutton_locator}
    Scroll Element Into View                      ${radiobutton_locator}   
    ${num}    Generate A Single Integer           ${random_1-7}
    Select Radio Button                           ${radiobutton}      ${num}  
    ${result}    Run Keyword And Return Status    
    ...    Radio Button Should Not Be Selected    ${radiobutton}
    Run Keyword If    ${result} == True     Print    random radio button not selected    
    ...    ELSE    Print    random radio button selected
      
    
Automation Tools Check Box
    
    ${num}    Generate A Single Integer            ${random_0-2}    
    ${automation_checkbox_loc}     set variable    css = input[id='tool-${num}'] 
    Wait Until Element Is Visible                  ${automation_checkbox_loc}
    Select Checkbox                                ${automation_checkbox_loc}  
    Checkbox Should Be Selected                    ${automation_checkbox_loc} 
        
Select Random Field From Dropdown
    
    Wait Until Element Is Visible            ${dropdown_locator}  
    ${index}    Generate A Single Integer    ${random_0-6}
    Select From List By Index                ${dropdown_locator}    ${index}   
    ${value_list}    Get List Items          ${dropdown_locator}
    List Selection Should Be                 ${dropdown_locator}    ${value_list}[${index}]
    
Closing Browser
    
    #using sleep to see all the randon selections 
    sleep    3s
    Close Browser