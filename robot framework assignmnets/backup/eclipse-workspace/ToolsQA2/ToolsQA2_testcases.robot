*** Settings ***
Resource    ToolsQA2_keywords.robot



*** Test Cases ***

test
    Open The Browser
    Verify Page Open
    Text Input    ${firstname_locator}    ${firstname}
    Text Input    ${lastname_locator}     ${lastname}
    Select Male Radio Button
    Text Input    ${date_locator}         ${date}
    Automation Tester Checkbox
    Selenium Commands Selector
    Profile Pic Selector
    Sleep    5s
    Close Browser