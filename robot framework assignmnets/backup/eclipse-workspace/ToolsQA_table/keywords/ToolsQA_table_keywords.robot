*** Settings ***
Documentation    this file contains the keywords used in th eproject

Resource    ../variables/ToolsQA_table_variables.robot

*** Keywords ***

Open The Browser
    Open Browser    ${url}   ${browser}
    Maximize Browser Window
    Set Browser Implicit Wait    5s
    
Print
    [Arguments]    ${message}
    log    ${message}
    Log To Console    ${message
   
Country Col Values
    Wait Until Element Is Visible    ${table_locator}
    Remove From List    ${country_list}    0   
    FOR    ${index}     IN RANGE     @{Country_row_range}
        ${res}     Get Table Cell    ${table_locator}    ${index}    ${country_column}
        Append To List    ${country_list}    ${res}          
    END
    Print    ${country_list} 
    
4th Row Details
    Wait Until Element Is Visible    ${table_locator}
    Remove From List    ${row_list}    0   
    FOR    ${index}     IN RANGE     @{column_range}
        ${res}     Get Table Cell    ${table_locator}    ${forth_row}    ${index}
        Append To List               ${row_list}    ${res}          
    END
    Print    ${row_list}   
    
       