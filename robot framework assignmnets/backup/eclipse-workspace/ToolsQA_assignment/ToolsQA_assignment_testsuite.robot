*** Settings ***
Documentation    this file contains the test cases for the toolsQA website 

Resource    ToolsQA_assignment_resource.robot

*** Test Cases ***

OPening the browser
    Open Brower And Open Page 
    
Test Practice Automation Form   
    Verify Practice Automation Form
    
Test Linktest
    Verify Link Test
    
Test Radio Button
     Year Of Experience Radio Button   
     
Test Check Box
    Automation Tools Check Box    
    
Test Dropdown    
    Select Random Field From Dropdown
    
close the browser
    Closing Browser