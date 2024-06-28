import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import CityState from './CityState';
import Popup from './Popup'
import { useNavigate } from 'react-router-dom';
import { useState } from 'react';


export default function Home() {
    const navigate = useNavigate();
    // const [data,setData]=useState({name:"Mayur"});
    const [dataFromCityState, setDataFromCityState] = useState();
    console.log("+++++++++" + dataFromCityState)
    // const receiveDataFromCityState = (data) => {

    //     setDataFromCityState(data.cityId);
    //     console.log(data)
    //   };

    const [formData, setFormData] = useState({
        first_name: '',
        last_name: '',
        email_id: '',
        mobile_number: '',
        address: '',
        driving_license_no: '',
        passport_no: '',
        state: '',
        aadhaar: '', 
        city: {
          cityId: ''
        }, 
        state: {
          stateId: ''
        }
      });

      

    const nextPage = (e) => {
        e.preventDefault();
        navigate(`/LocationSelector/${dataFromCityState}`,{state:dataFromCityState});
    }
    return (
        <>
            <div className="background-image">


                <Container className='container ' >
                    <Row>
                        <Col style={{ minWidth: 'fit-content' }}>
                            <h5>Make Reservation</h5>
                            <form>
                                <table className='tbl'>
                                    <tr>
                                        <td><label for='date'>Rental Date & Time :</label></td>
                                        <td><input type='datetime-local' id='date'></input></td>
                                    </tr>
                                    <tr>
                                        <td><label for='rdate'>Return Date & Time :</label></td>
                                        <td><input type='datetime-local' id='rdate'></input></td>
                                    </tr>
                                    <h6>Pickup Location</h6>
                                    <tr>
                                        <div>
                                        <td><label for='loc'>Enter Airport Code</label></td>
                                        <td><input type='text' id='loc'></input></td>
                                        <td><a href='#href'>Find Airport</a></td>
                                        </div>
                                    </tr>
                                    <h6>OR</h6>
                                    <tr>
                                        <CityState datacityState={dataFromCityState} sendDataToParent={setDataFromCityState}></CityState>
                                    </tr>
                                    <tr>
                                        <div>
                                        <td style={{ textAlign: 'end' }}><input type='checkbox'></input></td>
                                        <td>I may return the car to different location</td>
                                        </div>
                                    </tr>
                                    <h6>Return Location</h6>
                                    <tr>
                                        <div>
                                        <td><label for='loc'>Enter Airport Code</label></td>
                                        <td><input type='text' id='loc'></input></td>
                                        <td><a href='#href'>Find Airport</a></td>
                                        </div>
                                    </tr>
                                    <h6>OR</h6>

                                    <tr>
                                        <CityState></CityState>
                                    </tr>
                                    <tr><td><button onClick={nextPage}>Continue Booking</button></td></tr>
                                </table>
                            </form>
                        </Col>
                        {/* <Col className='homecol2'>2 of 2</Col> */}
                    </Row>

                </Container>
            </div>
        </>
    );
}
