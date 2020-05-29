import React, { Component } from 'react';

class Header extends Component {
    render() {

        if (this.props.data) {
            var name = this.props.data.name;
            var occupation = this.props.data.occupation;
            var city = this.props.data.address.city;
            var networks = this.props.data.social.map(function (network) {
                return <li key={network.name}><a href={network.url} target="_blank"><i className={network.className}></i></a></li>
            })
        }

        return (
            <header id="home">

                <nav id="nav-wrap" style={{ zIndex: '101' }} >

                    <a className="mobile-btn" href="#nav-wrap" title="Show navigation">Show navigation</a>
                    <a className="mobile-btn" href="#home" title="Hide navigation">Hide navigation</a>

                    <ul id="nav" className="nav">
                        <li className="current"><a className="smoothscroll" href="#home">Home</a></li>
                        <li><a className="smoothscroll" href="#about">About</a></li>
                        <li><a className="smoothscroll" href="#resume">Resume</a></li>
                        <li><a className="smoothscroll" href="#portfolio">Works</a></li>
                        <li><a className="smoothscroll" href="#teachingExpreience">TeachingExpreiences</a></li>
                        <li><a className="smoothscroll" href="#contact">Contact</a></li>
                    </ul>

                </nav>

                <div className="row banner">
                    <div className="banner-text">
                        <h1 className="responsive-headline">I'm {name}.</h1>
                        <h3>I'm a <span>{city}</span> based <span>{occupation}</span>. I have just got my <span>Bachelor's degree in Software Engineering</span> from <a style={{ zIndex: '102' }} href="https://en.kntu.ac.ir/" target="_blank">K. N. Toosi University of Technology</a> and planning to pursue my study for a <span>Graduate's Degree</span>.</h3>
                        <hr />
                        <ul className="social" >
                            {networks}
                        </ul>
                    </div>
                </div>

                <p className="scrolldown">
                    <a style={{ zIndex: '101' }}  className="smoothscroll" href="#about"><i className="icon-down-circle"></i></a>
                </p>

            </header>
        );
    }
}

export default Header;
