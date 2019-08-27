*** Settings ***
Documentation    this file contains the libraries and variables used in the project

Library    SeleniumLibrary
Library    Collections

*** Variables ***
${url}                            https://www.toolsqa.com/automation-practice-table/
${browser}                        gc    
${table_locator}                  xpath = //table[@class='tsc_table_s13']
@{country_list}                   ${EMPTY}
${country_column}                 2
@{Country_row_range}              2    6       
@{row_list}                       ${EMPTY}
${forth_row}                      5
@{column_range}                   1    8