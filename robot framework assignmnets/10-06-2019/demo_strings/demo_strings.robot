*** Settings ***
documentation    this file contains the use of string keywords
library     String    

*** Variables ***
#${name}    GuRu GoWrI KruPa TeChNoLoGiEs

*** Keywords ***
To Lowercase
    [Arguments]    ${string}
    ${result}    Convert To Lowercase    ${string}
    log to console    \n lowercase:${result}

To Uppercase
    [Arguments]    ${string}
    ${result}    Convert To Uppercase    ${string}
    log to console    \n uppercase:${result}  
    
string fetch from left
    [arguments]    ${string}    ${marker}
    ${result}    Fetch From Left      ${string}     ${marker}   
    log to console    \n fetch from left:${result}
    
string fetch from right
    [arguments]    ${string}    ${marker}
    ${result}    Fetch From right      ${string}     ${marker}   
    log to console    \n fetch from right:${result}
    
generate random string with letters and numbers
    [arguments]    ${length}    
    ${result}    Generate Random String    ${length}    
    log to console    \n generate random string:${result}
    
substring
    [Arguments]    ${string}    ${start}    ${end}
    ${result}    get substring    ${string}    ${start}    ${end}
    log to console    \n get substring:${result}
    
split string left
    [arguments]    ${string}    ${sep}
    @{words} =	Split String	${string}    ${sep}
    log to console    \n split string:@{words}
    
split string right
    [arguments]    ${string}    ${sep}
    @{words} =	Split String From Right	${string}    ${sep}
    log to console    \n split string from right:@{words}
    
check for Uppercase
    [Arguments]    ${string}
    Should Be Uppercase    ${string}     msg=not uppercase
    
check for Lowercase
    [Arguments]    ${string}   
    Should Be Lowercase    ${string}    msg=not lowercase
    

    

*** Test Cases ***
string keywords
    
    To Lowercase    GgkTECh
    To Uppercase    gGkTech
    string fetch from left    ggktech    t   
    string fetch from right    ggktech    t
    generate random string with letters and numbers   10    
    Substring    ggktech    2    6
    split string left    ggk-tech    -
    split string right    ggk-tech    -
    
check for uppercase
    check for uppercase    GGKTECH

check for lowercases
    check for lowercase    ggktech    



    