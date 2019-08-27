*** Settings ***
Documentation    this file contains the resources of the list data structure
   
library    Collections    

*** Variables ***
@{test_list}    99    98    97    96
${index}    1
${number}    95
${search_number}    91    
${delete_number}    97
${count_number}     99
${replace_number}    100

*** Keywords ***
Print
    [Arguments]    ${item}
    Log   \n ${item}\n
    Log To Console   \n ${item}\n
    
Insert To The List
    Insert Into List    ${test_list}   ${index}     ${number}
    Print    value ${number} inserted into list
    
Search From List

    ${index}    Get Index From List    ${test_list}    ${search_number}    
    Run Keyword If    ${index} != -1    Print    value ${search_number} found in list      
    ...    ELSE    Print    value ${search_number} not found in list     
    
Remove The Value From List
    
    ${index}    Get Index From List    ${test_list}    ${delete_number}
    Run Keyword If    ${index} != -1    Remove Values From List    ${test_list}    ${delete_number} 
    ...    ELSE    Print    ${delete_number} not found in list 
    Print     list after removing:${test_list}
    
Count Of A Particular Item
    
    ${count}    Count Values In List    ${test_list}    ${count_number}   
    Print    count of ${countnumber} : ${count} 
    
Total Count Of Items

    ${count}    Get Length    ${test_list}  
    Print    total count of items : ${count}
      
Update Item 

    Set List Value    ${test_list}    ${index}    ${replace_number}
    Print     replacing 95 as 100 : ${test_list}


    
       
  
