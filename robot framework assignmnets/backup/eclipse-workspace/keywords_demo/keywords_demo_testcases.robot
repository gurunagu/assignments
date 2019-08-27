*** Settings ***
Documentation    this file contains the test cases of the project.
resource     keywords_demo_resource.robot

*** Test Cases ***

positional keyword implementation
    positional keywords    redmi    6pro    android
    
default keywords implementation
    default keywords    redmi    6 pro
    print data    \n
    default keywords    apple    iphone X    os=ios  
  
named keywords implementation
    named keywords    A50    
    print data    \n
    named keywords    note 6 pro     brand=redmi
    print data    \n
    named keywords    iphone X    brand=iphone    os=ios