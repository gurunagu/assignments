*** Settings ***
Documentation    this file contains the libraries and variables for testing of toolsqa website

Library    SeleniumLibrary 
Library    String           

*** Variables ***
${url}                                https://www.toolsqa.com/automation-practice-form/
${browser}                            gc
${verify_automationForm_locator}      xpath = //div[@class='wpb_wrapper']/h1
${text_to_be_located}                 Practice Automation Form
${linktest_locator}                   css = a[title='Automation Practice Table']>strong
${linktestcheck_locator}              css = table[class='tsc_table_s13'] strong
${radiobutton}                        exp
${radiobutton_locator}                css = label[for='exp']
${length}                             1
${random_1-7}                         1234567
${random_0-2}                         012
${random_0-6}                         0123456
${sutomation_tool_locator}            css = input[id='tool-']
${dropdown_locator}                   xpath = //select[@id='continents']