*** Settings ***
Documentation    this file contains the keywords used in the project    

Resource    RFWSite_Variables.robot

*** Keywords ***

Open Browser And Open Google
    Open Browser    ${url}    ${browser}
    Maximize Browser Window
    
Element Click
    [Arguments]    ${loc}
    Wait Until Element Is Visible    ${loc}
    Element Should Be Visible        ${loc}
    Click Element                    ${loc}
        
Search Robot Framework
    Element Click                    ${google_search_locator}
    Clear Element Text               ${google_search_locator}
    Input Text                       ${google_s earch_locator}    ${input_RFW}
    Element Click                    ${search_button_locator}
    Wait Until Element Is Visible    ${google_img_locator}   
    Page Should Contain Image        ${google_img_locator}         

Robot Framework Click Link
    Element Click                    ${RFW_link_locator} 
    Wait Until Element Is Visible    ${RFW_img_locator}
 
Move Till Seleneium Library
    Element Click    ${libraries_locator}
    Element Click    ${external_locator}
    Element Click    ${selenium_library_locator}
    
Switch To Github and select documentation
    Select Window    ${tab_title}
    Wait Until Element Is Visible    ${github_locator}
    Element Click    ${documentation_locator}   
    
    
Close The Browser
    sleep     3s
    close browser
    
    
    
             
              
    