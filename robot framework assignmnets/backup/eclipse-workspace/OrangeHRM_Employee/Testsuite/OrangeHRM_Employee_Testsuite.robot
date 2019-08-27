*** Settings ***
Documentation    this file contains all the test cases for the project

Resource    ../Keywords/OrangeHRM_Employee_Keywords.robot
Resource    ../Keywords/Custom_keywords.robot

Suite Setup       Open Brower And Open Page
Suite Teardown    close the browser

*** Test Cases ***
Tsst Cases
    Login to OrangeHRM
    Navigate And Verify Add Employee Form
    Setting A Temporary User Data
    Filling Add Employee Form
    Edit Personal Details
    