import React from 'react';
import './CustomerCare.css'; // Don't forget to create this CSS file for styling


function CustomerCare() {
  return (
    <div className="customer-care-container">
      <h1>Customer Care</h1>
      <p>We're here to assist you. Choose from the options below to get the support you need.</p>

      <div className="support-options">
        <div className="option">
          <h2>Contact Us</h2>
          <p>If you have questions or need assistance, feel free to contact our customer support team.</p>
          <button className="btn-contact">Contact Us</button>
        </div>

        <div className="option">
          <h2>Frequently Asked Questions</h2>
          <p>Find answers to common questions in our FAQs section.</p>
          <button className="btn-faqs">View FAQs</button>
        </div>
      </div>

      <div className="contact-form">
        <h2>Have a Question?</h2>
        <p>If you couldn't find the answer in our FAQs, send us a message and we'll get back to you.</p>
        <form>
          <div className="form-group">
            <label htmlFor="name">Name</label>
            <input type="text" id="name" name="name" required />
          </div>
          <div className="form-group">
            <label htmlFor="email">Email</label>
            <input type="email" id="email" name="email" required />
          </div>
          <div className="form-group">
            <label htmlFor="message">Message</label>
            <textarea id="message" name="message" rows="4" required></textarea>
          </div>
          <button type="submit">Submit</button>
        </form>
      </div>
    </div>
  );
}

export default CustomerCare;
