import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import './header.css'
// import NavDropdown from 'react-bootstrap/NavDropdown';

function Header() {
  return (
    <Navbar collapseOnSelect expand="lg" className="custom-navbar">
      <Container>
        <Navbar.Brand href="Home" className='logoname'>INDIA DRIVE </Navbar.Brand>
        <Navbar.Toggle aria-controls="responsive-navbar-nav" />
        <Navbar.Collapse id="responsive-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link href="Modify">Modify/Cancel Booking</Nav.Link>
            <Nav.Link href="Registration">Membership Registration</Nav.Link>
            <Nav.Link href="AboutUs">About IndiaDrive</Nav.Link>
            <Nav.Link href="CustomerCare">Customer Care</Nav.Link>
          </Nav>
          <Nav>
            <Nav.Link href="Login"  className='login-button'>Login</Nav.Link>

          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}

export default Header;
