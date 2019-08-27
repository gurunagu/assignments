*** Settings *** ***
Documentation    this file contains the testcases of the project

Test Setup    Open Browser And Open Google
Test Teardown    Close The Browser
Resource    RFWSite_Keywords.robot

*** Test Cases ***

Test Cases 
    Search Robot Framework
    Robot Framework Click Link
    Move Till Seleneium Library
    Switch To Github and select documentation