*** Settings ***
Documentation    this file has the test cases of the table 

Suite Setup       Open The Browser
Suite Teardown    Close Browser

Resource    ../keywords/ToolsQA_table_keywords.robot
*** Test Cases ***
table test cases
    Country Col Values
    4th Row Details