*** Settings ***
Documentation    this file contains the variables used to test the browser windows

Library    SeleniumLibrary    

*** Variables ***

${url}                            http://www.seleniumframework.com/Practiceform/
${browser}                        gc
${page_title}                     title = Selenium Framework |   Practiceform
${page_verify_locator}            xpath = //div[@class='wpb_wrapper']/h2
${new_window_locator}             css = button[id='button1']
${new_window_title}               title = Selenium Framework | Selenium, Cucumber, Ruby, Java et al.
${new_window_verify_loc}          xpath = //strong[contains(text(),'Agile')]
${new_msg_window_loc}             xpath = //div[@class='wpb_wrapper']/p[3]/button
${new_msg_window_title}           This message window is only for viewing purposes
${new_msg_window_verify_loc}      xpath = /html/body[contains(text(),'This message window is only for viewing purposes')]
${new_tab_locator}                xpath = //div[@class='wpb_wrapper']/p[4]/button
${alert_locator}                  css = button[id='alert']
${alert text}                     Please share this website with your friends and in your organization.
${link_text_locator}              css = a[title='seleniumframework']