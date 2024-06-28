import React from 'react';
import './footer.css';
import {
  MDBFooter,
  MDBContainer,
  MDBCol,
  MDBRow,
} from 'mdb-react-ui-kit';

export default function App() {
  return (
    <MDBFooter className='custom-footer'>
      <MDBContainer className='p-4'>
        <MDBRow>
          <MDBCol lg="6" md="12" className='mb-4 mb-md-0'>
            <h5 className='text-uppercase'>About</h5>

            <p>
            Renaissance Rent A Car is a local car rental provider with more than 25 years of experience in the car rental industry. 
            We offer a varied fleet of cars, ranging from the compact to the 8-seater. All our vehicles have air 
            conditioning,  power steering, electric windows.
            We pride ourselves on personalized service, great cars and excellent rates.
            </p>
          </MDBCol>

          <MDBCol lg="3" md="6" className='mb-4 mb-md-0'>
            <h5 className='text-uppercase' >Contact Us</h5>

            <ul className='list-unstyled mb-0'>
              <li>
                <a href='#!' className='text-white'>
                  IndiaDrive@gmail.com
                </a>
              </li>
              <li className='text-white'>
                8855664477
              </li>
              <li className='text-white'>
                Mumbai, Maharashtra
              </li>
            </ul>
          </MDBCol>

          <MDBCol lg="3" md="6" className='mb-4 mb-md-0'>
            <h5 className='text-uppercase mb-0'>More</h5>

            <ul className='list-unstyled'>
              <li>
                <a href='#!' className='text-white'>
                  Weather
                </a>
              </li>
              <li>
                <a href='#!' className='text-white'>
                  Site Map
                </a>
              </li>
              <li>
                <a href='#!' className='text-white'>
                 Career
                </a>
              </li>
              <li>
                <a href='#!' className='text-white'>
                  Affiliated Hotels
                </a>
              </li>
            </ul>
          </MDBCol>
        </MDBRow>
      </MDBContainer>

      <div className='text-center p-3' style={{ backgroundColor: 'rgba(0, 0, 0, 0.2)' }}>
        © 2023 Copyright:
        <a className='text-white' href='https://indiadrive.com/'>
        indiadrive.com
        </a>
      </div>
    </MDBFooter>
  );
}