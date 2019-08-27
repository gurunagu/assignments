*** Settings ***
Documentation    this file contains the resources that are used in the project.

*** Keywords ***

print data
    [Arguments]    ${message}
    log    ${message}
    Log To Console    ${message}       
    
positional keywords
    [Arguments]    ${phone_model}    ${brand}    ${os}
    log to console    \n
    print data    brand:${brand}
    print data    phone model:${phone_model}
    print data    os:${os}
    
default keywords
    [Arguments]   ${phone_model}    ${brand}    ${os}=android
    print data    brand:${brand}
    print data    phone model:${phone_model}
    print data    os:${os}
    
named keywords
    [Arguments]    ${phone_model}    ${brand}=samsung    ${os}=android
    print data    brand:${brand}
    print data    phone model:${phone_model}
    print data    os:${os}
    