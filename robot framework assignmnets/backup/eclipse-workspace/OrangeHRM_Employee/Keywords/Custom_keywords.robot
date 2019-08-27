*** Settings ***
Documentation    This file contains the customized common keywords used in the project

Library    SeleniumLibrary
Library    String    

# importing the login_assignment for login functionality usage
Resource    ../../login_assignment/login_assignment_resource.robot

*** Variables ***
${random_index}            10
${random_alphanumeric}     [LETTERS][NUMBERS]

*** Keywords ***
Clear And Enter Input Text
    [Arguments]           ${loc}    ${text}
    Click On Element      ${loc}
    Clear Element Text    ${loc}
    Input Text            ${loc}    ${text}
    
Select From DropDown With Value
    [Arguments]    
    ...    ${loc}
    ...    ${label}
    Element Should Be Visible         ${loc}   
    Select From List By Label         ${loc}           ${label}
    
Generate Random Sequence of size 10
    ${result}     Generate Random String    ${random_index}    ${random_alphanumeric}
    [return]    ${result}
    