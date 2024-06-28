  import React from 'react';
  import './addon.css';
  import { useNavigate } from 'react-router-dom';
  import { useLocation } from 'react-router-dom';

  function Addon() {

    const navigate = useNavigate(); 

  
  const redirectHome = () => {
    navigate('/Home'); 
  };

  const location = useLocation();
  const selectedVehicle = location.state;

  console.log(selectedVehicle);


  return (
    <div className="addon">
      <div className="addon-box">
        <h3>Rental Add-ons</h3>
        <table className="addon-table">
          <tbody>
            <tr>
              <td>
              <input type="checkbox" id="gps" />
                <label htmlFor="gps">GPS Navigation System</label>
              </td>
              <td>$10.00 /day</td>
            </tr>
            <tr>
              <td>
                <input type="checkbox" id="kit" />
                <label htmlFor="kit">Camping Kit</label>
              </td>
              <td>$30.00 /day</td>
            </tr>
            <tr>
              <td>
                <input type="checkbox" id="seat" />
                <label htmlFor="seat">Child Seats (For additional seat. 1 seat free)</label>
              </td>
              <td>$2.00 /day</td>
            </tr>
            <tr>
              <td>
                <label htmlFor="numSeats">Please enter No. Of Seats:</label>
                <input type="text" id="numSeats" name="numSeats" />
              </td>
              <td></td>
            </tr>
            <br></br>
              <tr>
                  <td>
                  <button id="continue" style={{ fontSize: '20px' }}>Continue Booking</button>
                  </td>
                  <td>
                  <button type="reset" id="cancel" style={{ fontSize: '20px' }} onClick={redirectHome}>Cancel</button>
                  </td>
              </tr>
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default Addon;