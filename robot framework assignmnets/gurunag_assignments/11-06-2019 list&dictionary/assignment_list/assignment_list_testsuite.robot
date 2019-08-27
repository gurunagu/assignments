*** Settings ***
Documentation    this file contains the test cases used from resource file

resource    assignment_list_resource.robot

*** Test Cases ***

Testcases of lists
    
    Insert To The List    
    Print    ${test_list} 
    Search From List      
    Remove The Value From List              
    Count Of A Particular Item      
    Total Count Of Items    
    Update Item  
    
