*** Settings ***
Documentation    this file contains the login test cases

Resource    login_assignment_resource.robot

*** Test Cases ***

Login Verification
    Open Brower And Open Page
    Verify The Login Page
    Enter Username
    Enter Password
    click on signin button
    Verify Logged In Page
    close the browser