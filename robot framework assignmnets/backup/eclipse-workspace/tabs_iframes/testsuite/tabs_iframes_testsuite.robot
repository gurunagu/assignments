*** Settings ***
Documentation    this file has the test cases of the table 

Suite Setup       Open The Browser
 Suite Teardown    Close The Browser

Resource    ../keywords/tabs_iframes_keywords.robot

*** Test Cases ***

Frames Test Cases
    Verify Practice Automation Form
    Select Iframe Tab
    Frame and Email Enter
    verify Subscribe