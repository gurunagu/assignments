*** Settings ***
Documentation    this file contains the test cases of the dictionary data structure

resource    assignment_dictionary_resource.robot

*** Test Cases ***

Testcases of dictionary
    
    Insert To Dictionary       
    Print    Dictionary : ${dictionary}   
    Delete From Dictionary    
    Update Value Based On Key      
    Count Of Key-Value Pairs    
    
Search using keys dictionary cases
    Search Key         
    
Search using values dictionary cases
    Search Value     
    
