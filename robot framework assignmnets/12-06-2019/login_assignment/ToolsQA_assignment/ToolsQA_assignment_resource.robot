*** Settings ***
Documentation    this file contains the resources for testing of toolsqa website

Library    SeleniumLibrary 
Library    String           

*** Variables ***
${url}    https://www.toolsqa.com/automation-practice-form/
${browser}    gc
${verify_automationForm_locator}    xpath = //div[@class='wpb_wrapper']/h1
${text_to_be_located}    Practice Automation Form
${linktest_locator}    css = a[title='Automation Practice Table']>strong
${linktestcheck_locator}    css = table[class='tsc_table_s13'] strong
${radiobutton}    exp
${radiobutton_locator}    css = label[for='exp']
${length}    1
${random_1-7}    1234567
${random_0-2}    012
${random_0-6}    0123456
${sutomation_tool_locator}    css = input[id='tool-']
${dropdown_locator}    css = select[id='continents']

*** Keywords ***
Print 
    
    [Arguments]    ${message}
    Log    \n${message}\n
    Log To Console    \n${message}\n
    
Generate A Single Integer
    
    [Arguments]    ${random}
    ${num}    Generate Random String    ${length}    ${random}
    [return]    ${num}    
    
Open Brower And Open Page
    
    Open Browser    ${url}    ${browser}
    Maximize Browser Window
    
Verify Practice Automation Form
    
    Wait Until Element Is Visible    ${verify_automationForm_locator} 
    ${result}     Element Should Contain    ${verify_automationForm_locator}     ${text_to_be_located}    
    Run Keyword If    ${result} == None    Print    '${text_to_be_located}' found in page
    
Verify Link Test
    
    Click Element    ${linktest_locator} 
    Wait Until Element Is Visible    ${linktestcheck_locator}
    ${result}     Element Should Be Visible    ${linktestcheck_locator}  
    Run Keyword If    ${result} == None     Print    link test verified    
    ...    ELSE    Print    link test failed
    Go Back
      
Year Of Experience Radio Button   
    
    Wait Until Element Is Visible    ${radiobutton_locator}
    Scroll Element Into View    ${radiobutton_locator}   
    ${num}    Generate A Single Integer    ${random_1-7}
    Select Radio Button    ${radiobutton}      ${num}  
    
Automation Tools Check Box
    
    ${num}    Generate A Single Integer    ${random_0-2}    
    ${automation_checkbox_loc}     set variable    css = input[id='tool-${num}'] 
    Wait Until Element Is Visible    ${automation_checkbox_loc}
    Scroll Element Into View       ${automation_checkbox_loc}
    Scroll Element Into View       ${automation_checkbox_loc}
    Select Checkbox    ${automation_checkbox_loc}  
        
Select Random Field From Dropdown
    
    Wait Until Element Is Visible        ${dropdown_locator} 
    Scroll Element Into View     ${dropdown_locator} 
    ${index}    Generate A Single Integer    ${random_0-6}
    Select From List By Index    ${dropdown_locator}    ${index}   
    
Closing Browser
    
    #using sleep to see all the randon selections 
    sleep    3s
    Close Browser