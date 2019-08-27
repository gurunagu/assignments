*** Settings ***
Documentation    this file has the common keywords used in the project


Resource    ../libraries/OrangeHRM_user_libraries.robot
#importing the login credintials already used in login_assignment project
Resource    ../../login_assignment/login_assignment_resource.robot
*** Keywords ***

    
Clear And Enter In Input Text
    [Arguments]           ${loc}    ${text}
    Click On Element      ${loc}
    Clear Element Text    ${loc}
    Input Text            ${loc}    ${text}
    
Select From DropDown With Value
    [Arguments]    
    ...    ${loc}
    ...    ${index}
    Element Should Be Visible         ${loc}   
    Select From List By Label         ${loc}           ${index}