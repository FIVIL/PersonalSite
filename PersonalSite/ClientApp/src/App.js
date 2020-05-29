import React, { Component } from 'react';
import $ from 'jquery';
import './App.css';
import Header from './Components/Header';
import Footer from './Components/Footer';
import About from './Components/About';
import Resume from './Components/Resume';
import Contact from './Components/Contact';
import TeachingExpreience from './Components/TeachingExpreience';
import Portfolio from './Components/Portfolio';

class App extends Component {

    constructor(props) {
        super(props);
        this.state = {
            resumeData: {}
        };

    }
    async getResumeData() {
        const response = await fetch('/api/Home');
        const data = await response.json();
        this.setState({ resumeData: data, loading: false });
    }

    componentDidMount() {
        this.getResumeData();
        window.particlesJS("particles-js", {
            "particles": {
                "number": {
                    "value": 80,
                    "density": {
                        "enable": true, "value_area": 600
                    }
                },
                "color":
                    { "value": "#ffffff" },
                "shape": {
                    "type": "circle",
                    "stroke": {
                        "width": 0, "color": "#000000"
                    },
                    "polygon": {
                        "nb_sides": 5
                    },
                    "image": {
                        "src": "img/github.svg",
                        "width": 100, "height": 100
                    }
                },
                "opacity": {
                    "value": 0.7,
                    "random": false,
                    "anim": {
                        "enable": false,
                        "speed": 1,
                        "opacity_min": 0.1,
                        "sync": false
                    }
                },
                "size": {
                    "value": 3,
                    "random": true,
                    "anim": {
                        "enable": false,
                        "speed": 40,
                        "size_min": 0.1,
                        "sync": false
                    }
                },
                "line_linked": {
                    "enable": true,
                    "distance": 150,
                    "color": "#ffffff",
                    "opacity": 0.4,
                    "width": 1
                },
                "move": {
                    "enable": true,
                    "speed": 2,
                    "direction": "none",
                    "random": false,
                    "straight": false,
                    "out_mode": "out",
                    "bounce": false,
                    "attract": {
                        "enable": false,
                        "rotateX": 600,
                        "rotateY": 1200
                    }
                }
            },
            "interactivity": {
                "detect_on": "canvas",
                "events": {
                    "onhover": {
                        "enable": false,
                        "mode": "repulse"
                    },
                    "onclick": {
                        "enable": true,
                        "mode": "push"
                    },
                    "resize": true
                },
                "modes": {
                    "grab": {
                        "distance": 400,
                        "line_linked": {
                            "opacity": 1
                        }
                    },
                    "bubble": {
                        "distance": 400,
                        "size": 40,
                        "duration": 2,
                        "opacity": 8,
                        "speed": 3
                    },
                    "repulse": {
                        "distance": 200,
                        "duration": 0.4
                    },
                    "push": {
                        "particles_nb": 4
                    },
                    "remove": {
                        "particles_nb": 2
                    }
                }
            },
            "retina_detect": true
        });
    }

    render() {
        return (
            <div className="App" >
                <div id="particles-js" />
                <div className="sitecss">
                    <Header data={this.state.resumeData.main} />
                    <About data={this.state.resumeData.main} />
                    <Resume data={this.state.resumeData.resume} />
                    <Portfolio data={this.state.resumeData.portfolio} />
                    <TeachingExpreience data={this.state.resumeData.teachingExpreiences} />
                    <Contact data={this.state.resumeData.main} />
                    <Footer data={this.state.resumeData.main} />
                </div>
            </div>
        );
    }
}

export default App;
