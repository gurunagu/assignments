*** Settings ***
Documentation    this file contains the resources of the dictionary data structure
   
library    Collections    

*** Variables ***
&{dictionary}    a=100    b=101    c=102    d=103
${insert_key}    e
${insert_value}    104
${delete_key}    c
${update_key}    a
${update_value}    200
${search_key}    f
${search_value}    103

*** Keywords ***
Insert To Dictionary 
    Set To Dictionary    ${dictionary}    ${insert_key}     ${insert_value}   
    Print     After Inserting '${insert_key}'=${insert_value} : ${dictionary}

Print 
    [Arguments]    ${message}
    Log    \n${message}\n
    Log To Console    \n${message}\n
      
Delete From Dictionary   
    Remove From Dictionary    ${dictionary}    ${delete_key}
    Print     After Deleting '${delete_key}' : ${dictionary} 
    
Count Of Key-Value Pairs

    ${count}    Get Length    ${dictionary}
    Print    Count of Key-Value Pairs in Dictionary : ${count}
Update Value Based On Key

    Set To Dictionary    ${dictionary}    ${update_key}     ${update_value}   
    Print     After Updating '${update_key}'=${update_value} : ${dictionary}
    
Search Key 
      
    Dictionary Should Contain Key    ${dictionary}    ${search_key}    msg='${search_key}' key not found 

Search Value

    Dictionary Should Contain Value    ${dictionary}    ${search_value}    msg='${search_value}' value not found 
    
