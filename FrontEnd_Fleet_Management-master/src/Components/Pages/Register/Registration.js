import React, { useState } from 'react';
import './RegistrationForm.css';
import * as yup from 'yup';
import { Container } from 'react-bootstrap';

// const schema = yup.object().shape({
//   first_name: yup.string().required('First name is required'),
//   last_name: yup.string().required('Last name is required'),
//   email_id: yup.string().email('Invalid email format').required('Email is required'),
//   mobile_number: yup.string().required('Mobile number is required'),
//   address: yup.string().required('Address is required'),
//   driving_license_no: yup.string().required('Driving License No. is required'),
//   passport_no: yup.string().required('Passport No. is required'),
//   state: yup.string().required('State is required'),
//   city: yup.string().required('City is required'),
// });

function Registration  ()  {
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

  const [errors, setErrors] = useState({});

  function handleChange (event) {
    const { name, value } = event.target;
    setFormData({
      ...formData,
      [name]: value,
    });
  };

  function handleSubmit (event) {
    event.preventDefault();
    console.log('Form submitted:', formData);

    const data = {
      firstName: formData.first_name,
      lastName: formData.last_name,
      mobileNumber: formData.mobile_number,
      address: formData.address,
      emailId: formData.email_id,
      dlNo: formData.driving_license_no,
      aadharNo: formData.aadhaar,
      passportNo: formData.passport_no, 
      city: {
        cityId: 2110
      }, 
      state: {
        stateId: 21 
      }
    };

    fetch("http://localhost:8080/api/user/add", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(data),
    })
    .then((res) => {
      if (!res.ok) {
        throw new Error("Network response was not ok");
      }
      const contentType = res.headers.get("content-type");
        if (contentType && contentType.includes("application/json")) {
          return res.json();
        } else {
          return {};
        }
      })
      .catch((error) => {
        console.error("Registration error:", error);
        // Handle registration errors here, e.g., display error messages to the user
      }); 
  }

  return (
    <Container fluid className="registration-bg-container">
    <div className="registration-form-container">
      <h2>Registration Form</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label htmlFor="first_name">First Name</label>
          <input
            type="text"
            id="first_name"
            name="first_name"
            value={formData.first_name}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="last_name">Last Name</label>
          <input
            type="text"
            id="last_name"
            name="last_name"
            value={formData.last_name}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="email_id">Email</label>
          <input
            type="email"
            id="email_id"
            name="email_id"
            value={formData.email_id}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="mobile_number">Mobile Number</label>
          <input
            type="text"
            id="mobile_number"
            name="mobile_number"
            value={formData.mobile_number}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="aadhaar">Aadhaar Number</label>
          <input
            type="text"
            id="aadhaar"
            name="aadhaar"
            value={formData.aadhaar}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="address">Address</label>
          <input
            type="text"
            id="address"
            name="address"
            value={formData.address}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="driving_license_no">Driving License No.</label>
          <input
            type="text"
            id="driving_license_no"
            name="driving_license_no"
            value={formData.driving_license_no}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="passport_no">Passport No.</label>
          <input
            type="text"
            id="passport_no"
            name="passport_no"
            value={formData.passport_no}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="state">State</label>
          <input
            type="text"
            id="state"
            name="state"
            value={formData.state}
            onChange={handleChange}
          />
        </div>
        <div>
          <label htmlFor="city">City</label>
          <input
            type="text"
            id="city"
            name="city"
            value={formData.city}
            onChange={handleChange}
          />
        </div>
        <button type="submit">Submit</button>
      </form>
    </div>
  </Container>
  );
};

export default Registration;
