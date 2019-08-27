*** Settings ***
Documentation    this file contains the testcases used in the project

Suite Setup    Open The Browser
Suite Teardown    Close The Browser
Test Teardown     Close Window

Resource    ../keywords/browser_control_keywords.robot

*** Test Cases ***

New Window Test Case
    New Browser Window
    
New Message window Test Case
    New Message Window
    
new tab test case
    New Tab Window
    
Alert window
    Handle The Alert
    [Teardown]    log     Alert has been handled   
    
Link text test
    Link Text Window