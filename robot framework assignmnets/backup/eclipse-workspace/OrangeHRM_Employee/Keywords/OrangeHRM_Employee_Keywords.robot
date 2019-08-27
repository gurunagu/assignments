*** Settings ***
Documentation    This file contains all the variables and keywords used in the project

    

Resource    Custom_keywords.robot


*** Variables ***
${PIM_loc}                                  xpath = //a[@id='menu_pim_viewPimModule']/b
${add_employee_loc}                         css = a[id='menu_pim_addEmployee']
${add_employee_page_loc}                    xpath = //div[@class='head']/h1
${add_emp_FirstName_loc}                    css = input[id='firstName']
${first_name}                               ${empty}
${add_emp_LastName_loc}                     css = input[id='lastName']
${last_name}                                ${empty}
${Add_employee_Employee_id_loc}             css = input[name='employeeId']
${Employee_id}                              ${empty}   
${add_employee_photograph _loc}             css = input[name='photofile']
${Photograph_location}                      C:/Users/Gurunag.U/eclipse-workspace/OrangeHRM_Employee/Photograph.jpg
${add_employee_save_button}                 css = input[id='btnSave']
${personal_details_page_loc}                xpath = //div[@class='personalDetails']/div[1]/h1
${personal_details_edit&save_btn_loc}            css = input[id='btnSave']
${Personal_details_middlename_loc}          css = input[title='Middle Name']
${middle_name}                              ${empty}
${personal_details_DL_loc}                  css = input[name='personal[txtLicenNo]']
${Driving_license_number}                   ${empty}
${Personal_details_license_exp_loc}         css = input[name='personal[txtLicExpDate]']
${licence_expiry_date}                      2020-02-20
${expiry_date_symbol_loc}                   xpath = //form[@id='frmEmpPersonalDetails']/fieldset/ol[2]/li[4]/img
${gender_radio_male_loc}                    css = [id="personal_optGender_1"]     
${Marital_status_loc}                       css = select[id='personal_cmbMarital']   
${Marital_status_label}                     Married
${nationality_loc}                          css = select[id='personal_cmbNation']
${nationality_label}                        Indian
${date_of_birth_loc}                        css = input[id='personal_DOB']
${date_of_birth}                            1998-07-12


*** Keywords ***

Login to OrangeHRM
    Verify The Login Page
    Enter Username
    Enter Password
    click on signin button
    Verify Logged In Page
    
Navigate And Verify Add Employee Form
    Click On Element                    ${PIM_loc}
    Click On Element                    ${add_employee_loc}
    Wait Until Element Is Visible       ${add_employee_page_loc}
    ${result}    Run Keyword And Return Status    Element Should Be Visible    ${add_employee_page_loc}
    Run Keyword If    ${result}==True 
    ...    Print    Add Employee form succesfully loaded    ELSE
    ...    Print    Add Employee form failed to load

Setting A Temporary User Data
    ${res}    Generate Random Sequence of size 10
    Set Global Variable    ${first_name}    ${res}
    ${res}    Generate Random Sequence of size 10
    Set Global Variable    ${last_name}    ${res}  
    ${res}    Generate Random Sequence of size 10
    Set Global Variable    ${middle_name}    ${res}
    ${res}    Generate Random Sequence of size 10
    Set Global Variable    ${Driving_license_number}    ${res}       

Filling Add Employee Form
    Clear And Enter Input Text            ${add_emp_FirstName_loc}            ${first_name}
    Clear And Enter Input Text            ${add_emp_LastName_loc}             ${last_name}
    ${result}    Get Value                ${Add_employee_Employee_id_loc}
    Set Global Variable                   ${Employee_id}                      ${result}
    Choose File                           ${add_employee_photograph _loc}     ${Photograph_location} 
    Click On Element                      ${add_employee_save_button}
    ${result}    Run Keyword And Return Status    Element Should Be Visible    ${personal_details_page_loc}
    Run Keyword If    ${result}==True 
    ...    Print    Succesfully Cretaed Employee    ELSE
    ...    Print    Failed to ccreate employee

Edit Personal Details
    Wait Until Element Is Visible            ${personal_details_page_loc}   
    Click On Element                         ${personal_details_edit&save_btn_loc}
    Clear And Enter Input Text               ${Personal_details_middlename_loc}     ${middle_name}
    Clear And Enter Input Text               ${personal_details_DL_loc}             ${Driving_license_number}
    Clear And Enter Input Text               ${Personal_details_license_exp_loc}    ${licence_expiry_date}
    Click On Element                         ${expiry_date_symbol_loc}
    Click On Element                         ${gender_radio_male_loc}             
    Select From DropDown With Value   	     ${Marital_status_loc}                  ${Marital_status_label}
    Select From DropDown With Value   	     ${nationality_loc}                     ${nationality_label}   
    Clear And Enter Input Text               ${date_of_birth_loc}                   ${date_of_birth}
    Click On Element                         ${personal_details_edit&save_btn_loc}    

    
    
    
     

             