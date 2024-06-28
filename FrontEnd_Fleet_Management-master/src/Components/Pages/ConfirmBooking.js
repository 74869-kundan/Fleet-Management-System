import React from "react";
import Container from "react-bootstrap/esm/Container";
import Col from 'react-bootstrap/Col';
import Form from 'react-bootstrap/Form';
import Row from 'react-bootstrap/Row';
import  ReactDOM  from "react-dom";

export default function ConfirmBooking() 
{
    console.log("Inside Confirm booking");
  return(
    
    <Container className="container">
      <br></br>
    <Row>
      {/* <Col>
      <Form>
      <table>
        <tr>
          <td><label for='member'>Membership No. </label></td>
          <td><input type="text" id="member"></input></td>
        </tr>
        <br></br>
        <tr>
          <td><label for='password'>Password </label></td>
          <td><input type="text" id="password"></input></td>
        </tr>
        <br></br>
        <tr>
          <td></td>
          <td><button >Go</button></td>
        </tr>
      </table>
      </Form>
      </Col> */}

      <br></br>
      <Col>
      <Form>
        <table>
        <tr>
            <td><label for='pickup'>PickUp </label></td>
            <td><input type="datetime-local" id="pickup_date_time" placeholder="dd/mm/yyyy"></input></td>
            <td><label for='pickup'>Return </label></td>
            <td><input type="datetime-local" id="return_date_time" placeholder="dd/mm/yyyy"></input></td>
          </tr>
          <br></br>
          <tr>
            <td><label for='pickup_at'>Pick-Up at</label></td>
            <td><input type="text" id="pickup_at" placeholder=""></input></td>
            <td><label for='return_at'>Return at</label></td>
            <td><input type="text" id="return_at" ></input></td>
          </tr>
          <br></br>
          <tr>
            <td><label for="vehicle_type">Vehicle Type</label></td>
            <td><input type="text" id="vehicle_type" placeholder="xxxxxxx"></input></td>
            <td><label for="rental_add_on">Rental Add-On</label></td>
            <td><input type="text" id="rental_add_on"></input></td>
          </tr>
          <tr>
            <td><label for='rentername'>Renter's Name: </label></td>
            <td><input type="text" id="rentername" placeholder="First Name"></input></td>
            <td><input type="text" id="rentername" placeholder="Last Name"></input></td>
          </tr>
          <br></br>
          <tr>
          <td  ><label for='Address'>Address: </label></td>
          <td colSpan={2}><input type="text" style={{width:'550px'}} id="Address" placeholder="Address Line-1"></input></td>
        </tr>
        <br></br>
        <tr>
          <td></td>
          <td colSpan={2}><input type="text" style={{width:'550px'}} id="Address" placeholder="Address Line-2"></input></td>
        </tr>
        <br></br>
        <tr>
          <td  ><label for='email'>Email-id: </label></td>
          <td colSpan={2}><input type="text" style={{width:'380px'}} id="email" placeholder="Your email address "></input></td>
        </tr>
        <br></br>
        </table>
        <table>
        <tr>
            <td style={{paddingRight:'77px'}}><label for='city'>City:</label></td>
            <td colSpan={2}><input type="text" style={{width:'135px'}} id="city"></input></td>
            <td style={{paddingRight:'77px',paddingLeft:'66px'}}><label for='zip'>ZIP:</label></td>
            <td colSpan={2}><input type="text" style={{width:'135px'}} id="zip"></input></td>  
          </tr>
          <br></br>
          <tr>
            <td style={{paddingRight:'77px'}}><label for='homephone'>Home-Phone:</label></td>
            <td colSpan={2}><input type="text" style={{width:'135px'}} id="homephone"></input></td>
            <td style={{paddingRight:'77px',paddingLeft:'66px'}}><label for='mob'>Mob No.:</label></td>
            <td colSpan={2}><input type="text" style={{width:'135px'}} id="mob"></input></td>  
          </tr>
          <br></br>
          <tr>
            <td style={{paddingRight:'77px'}}><label for='cardtype'>Credit Card Type:</label></td>
            <td colSpan={2}><input type="text" style={{width:'135px'}} id="cardtype"></input></td>
            <td style={{paddingRight:'77px',paddingLeft:'66px'}}><label for='cardno'>No.:</label></td>
            <td colSpan={2}><input type="text" style={{width:'135px'}} id="cardno"></input></td>  
          </tr>

          <br></br>
          <tr>
            <td style={{paddingRight:'77px'}}><label for='licence'>Driving licence:</label></td>
            <td colSpan={2}><input type="text" style={{width:'135px'}} id="licence"></input></td>
            <td style={{paddingRight:'77px',paddingLeft:'66px'}}><label for='IDP'>IDP#:</label></td>
            <td colSpan={2}><input type="text" style={{width:'135px'}} id="IDP"></input></td>  
          </tr>
          <br></br>
          <tr>
          <td style={{paddingRight:'77px'}}><label for='issueby'>Issued by:</label></td>
          <td colSpan={2}><input type="text" style={{width:'135px'}} id="issueby"></input></td>
          <td style={{paddingRight:'77px',paddingLeft:'66px'}}><label for='valid'>Valid:</label></td>
          <td colSpan={2}><input type="text" style={{width:'135px'}} id="valid"></input></td>
          </tr>

          <br></br>
          <tr>
          <td style={{paddingRight:'77px'}}><label for='passport'>Passport No:</label></td>
          <td colSpan={2}><input type="text" style={{width:'135px'}} id="passport"></input></td>
          <td style={{paddingRight:'77px',paddingLeft:'66px'}}><label for='passportvalid'>Valid</label></td>
          <td colSpan={2}><input type="text" style={{width:'135px'}} id="passportvalid"></input></td> 
        </tr>

        <br></br>
          <tr>
          <td style={{paddingRight:'77px'}}><label for='issueby'>Issued by:</label></td>
          <td colSpan={2}><input type="text" style={{width:'135px'}} id="issueby"></input></td>
          <td style={{paddingRight:'77px',paddingLeft:'66px'}}><label for='date'>Date:</label></td>
          <td colSpan={2}><input type="text" style={{width:'135px'}} id="date"></input></td>
          </tr>

          <br></br>
          <tr>
          <td style={{paddingRight:'77px'}}><label for='dob'>Date of Birth:</label></td>
          <td colSpan={2}><input type="text" style={{width:'135px'}} id="dob"></input></td>
          </tr>

          <br></br>
          <tr>
            <td></td>
            <td colSpan={2}><button style={{width:'200px'}}>Continue Booking</button></td>
            <td></td>
            <td><button>Cancel</button></td>
          </tr>
          <br></br>
        </table>
     
        
      </Form>
      </Col>
  
    </Row>
  </Container>
  )
} 