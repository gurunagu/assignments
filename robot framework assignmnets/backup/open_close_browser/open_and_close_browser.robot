*** Settings ***
Documentation    this file contains of open and close browser scenario.

Library     SeleniumLibrary    

*** Variables ***
${url}    https://www.google.com/
${browser}    gc
${text_locator}    name=q  
${search_locator}    class=gNO89b
${RFW_locator}    class=LC20lb


*** Test Cases ***
open the browser
    open browser     ${url}    ${browser}
    Maximize Browser Window
    sleep     2s
    input password    ${text_locator}    robotframework
    sleep     2s
    Click Button    ${search_locator} 
    sleep     2s
    Click element    ${RFW_locator}
    sleep     5s
    Close Browser
