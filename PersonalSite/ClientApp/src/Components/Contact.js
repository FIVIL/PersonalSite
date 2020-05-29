import React, { Component } from 'react';
import $ from 'jquery';

class Contact extends Component {
    displayName = Contact.name

    constructor(props) {
        super(props);
        this.state = {
            contactName: '',
            contactEmail: '',
            contactSubject: '',
            contactMessage: ''
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleChange(event) {
        this.setState({
            [event.target.name]: event.target.value
        });
    }
    async handleSubmit(event) {
        event.preventDefault();
        $('#image-loader').fadeIn();
        const response = await fetch('/api/Home', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                email: this.state.contactEmail,
                message: this.state.contactMessage,
                name: this.state.contactName,
                subject: this.state.contactSubject,
                err: '',
                res: 'Your message was sent, thank you!'
            })
        });
        const data = await response.json();
        if (response.status == 200) {
            this.setState({ res: "Thank you for reaching me out! Your message has been sent successfully!!!" });
            $('#image-loader').fadeOut();
            $('#message-warning').hide();
            $('#contactForm').fadeOut();
            $('#message-success').fadeIn(); 
        } else {
            $('#image-loader').fadeOut();
            $('#message-warning').html("An Error happened while sending your message, Please try again!!!");
            $('#message-warning').fadeIn();
        }
    }
    render() {

        if (this.props.data) {
            var name = this.props.data.name;
            var street = this.props.data.address.street;
            var city = this.props.data.address.city;
            var state = this.props.data.address.state;
            var zip = this.props.data.address.zip;
            var phone = this.props.data.phone;
            var email = this.props.data.email;
            var message = this.props.data.contactmessage;
        }

        return (
            <section id="contact">
                <div className="row">
                    <div className="twelve columns">

                        <form onSubmit={this.handleSubmit} id="contactForm" name="contactForm">
                            <fieldset>

                                <div>
                                    <label htmlFor="contactName">Name <span className="required">*</span></label>
                                    <input required type="text" defaultValue="" size="35" id="contactName" name="contactName"
                                        value={this.state.contactName} onChange={this.handleChange} placeholder="Name" />
                                </div>

                                <div>
                                    <label htmlFor="contactEmail">Email <span className="required">*</span></label>
                                    <input required type="email" defaultValue="" size="35" id="contactEmail" name="contactEmail"
                                        value={this.state.contactEmail} onChange={this.handleChange} placeholder="example@example.com" />
                                </div>

                                <div>
                                    <label htmlFor="contactSubject">Subject</label>
                                    <input type="text" defaultValue="" size="35" id="contactSubject" name="contactSubject"
                                        value={this.state.contactSubject} onChange={this.handleChange} placeholder="subject" />
                                </div>

                                <div>
                                    <label htmlFor="contactMessage">Message <span className="required">*</span></label>
                                    <textarea cols="50" rows="15" id="contactMessage" name="contactMessage"
                                        value={this.state.contactMessage} onChange={this.handleChange}></textarea>
                                </div>

                                <div>
                                    <button className="submit">Submit</button>
                                    <span id="image-loader">
                                        <img alt="" src="images/loader.gif" />
                                    </span>
                                </div>
                            </fieldset>
                        </form>

                        <div id="message-warning"> {this.state.err}</div>
                        <div id="message-success">
                            <i className="fa fa-check">{this.state.res}</i><br />
                        </div>
                    </div>
                </div>
            </section>
        );
    }
}

export default Contact;
