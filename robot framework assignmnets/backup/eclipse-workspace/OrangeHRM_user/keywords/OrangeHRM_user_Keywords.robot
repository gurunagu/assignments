*** Settings ***
Documentation    this file contains the keywords used in the project


Resource    Shared_Keywords.robot

*** Keywords *** 
  
Login to OrangeHRM
    Verify The Login Page
    Enter Username
    Enter Password
    click on signin button
    Verify Logged In Page
    
Generate Random UserName And Password Dynamically
    ${random_name}        Generate Random String    ${Random_index}            ${alphanumeric}
    Set Global Variable                             ${new_username}            ${random_name} 
    ${random_password}    Generate Random String    ${Random_index}            ${alphanumeric}
    Set Global Variable                             ${new_password}            ${random_password}
    
Navigate to Users
    Click On Element    ${Admin_option_locator}
    Click On Element    ${user_management_loc}
    Click On Element    ${Users_Locator}
    Generate Random UserName And Password Dynamically
    
Navigate And Fill New User Form
    Click On Element                            ${add_user_locator}
    Wait Until Element Is Visible               ${add_user_page_loc}  
    Element Should Be Visible                   ${add_user_page_loc}  
       
    Select From DropDown With Value             ${user_role_loc}           ${user_role_label}
    Clear And Enter In Input Text               ${employee_name_loc}       ${employeename}     
    Clear And Enter In Input Text               ${username_loc}            ${new_username}   
    Select From DropDown With Value             ${status_loc}              ${status_role_label}    
    Clear And Enter In Input Text               ${password_loc}            ${new_password}  
    Clear And Enter In Input Text               ${confirm_password_loc}    ${new_password}
    Click On Element                            ${save_button_loc} 
    ${result}    Run Keyword And Return Status    Element Should Be Visible    ${System_users_locator}
    Run Keyword If    ${result}==True 
    ...    Print    Succesfully created the user    ELSE
    ...    Print    Failed to create the user    
    
Search The User
    Clear And Enter In Input Text               ${search_username_loc}         ${new_username}
    Select From DropDown With Value             ${search_user_role_loc}        ${user_role_label}
    Clear And Enter In Input Text               ${search_employee_name_loc}    ${employeename}
    Select From DropDown With Value             ${search_status_loc}           ${status_role_label}
    Click On Element                            ${search_button_loc}
    ${result}    Run Keyword And Return Status    Element Should Be Visible    ${search_checkbox_locator}
    Run Keyword If    ${result}==True 
    ...    Print     The user ${new_username} is present in the record
    ...        ELSE
    ...    Print    The user ${new_username} is not present in the record                    
    
Delete The User
    Element Should Be Visible          ${search_checkbox_locator}
    Checkbox Should Not Be Selected    ${search_checkbox_locator}
    Select Checkbox                    ${search_checkbox_locator}
    Checkbox Should Be Selected        ${search_checkbox_locator}
    Click On Element                   ${delete_button_loc} 
    Click On Element                   ${delete_ok_button_loc}
   
    
    
    