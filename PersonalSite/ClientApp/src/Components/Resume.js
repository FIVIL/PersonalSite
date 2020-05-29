import React, { Component } from 'react';
import $ from 'jquery';

class Resume extends Component {
    constructor(props) {
        super(props);
    }

    render() {

        if (this.props.data) {
            var skillmessage = this.props.data.skillmessage;
            var design = this.props.data.designLang;
            var consepts = this.props.data.consepts;
            var databases = this.props.data.databases;
            var frameworks = this.props.data.frameworks;
            var libraries = this.props.data.libraries;
            var tools = this.props.data.tools;

            var education = this.props.data.education.map(function (education) {
                return <div key={education.school}><h3>{education.school}</h3>
                    <p className="info">{education.degree} <span>&bull;</span><em className="date">{education.graduated}</em> <span>&bull;</span> <em className="date">{education.gpa}</em></p>
                    <a href="https://github.com/FIVIL/ParsiCoin" target="_blank">{education.description}</a>
                    <p className="info" style={{ fontWeight: 'bold' }}>Selected Courses: <em>{education.courses}</em></p>
                </div>
            })
            var work = this.props.data.work.map(function (work) {
                return <div key={work.company}><h3>{work.company}</h3>
                    <p className="info">{work.title}<span>&bull;</span> <em className="date">{work.years}</em></p>
                    <p>{work.description}</p>
                    <p className="info" style={{ fontWeight: 'bold' }}>Duties: <em>{work.duties}</em></p>
                </div>
            })
            var skills = this.props.data.skills.map(function (skills) {
                var className = 'bar-expand ';//+ skills.name.replace("#", "S").replace("+", "p").toLowerCase();
                return <li key={skills.name}><span style={{ width: skills.level }} className={className}></span><em>{skills.name}</em></li>
            })
        }

        return (
            <section id="resume">

                <div className="row education">
                    <div className="three columns header-col">
                        <h1><span>Education</span></h1>
                    </div>

                    <div className="nine columns main-col">
                        <div className="row item">
                            <div className="twelve columns">
                                {education}
                            </div>
                        </div>
                    </div>
                </div>


                <div className="row work">

                    <div className="three columns header-col">
                        <h1><span>Work</span></h1>
                    </div>

                    <div className="nine columns main-col">
                        {work}
                    </div>
                </div>



                <div className="row skill">

                    <div className="three columns header-col">
                        <h1><span>Skills</span></h1>
                    </div>

                    <div className="nine columns main-col">

                        <p>{skillmessage}
                        </p>

                        <div className="bars">
                            <ul className="skills">
                                {skills}
                            </ul>
                        </div>
                    </div>
                    <div className="three columns header-col">
                        <h1><span>Other Skills</span></h1>
                    </div>
                    <div className="nine columns main-col">
                        <p className="info" style={{ fontWeight: 'bold' }}>Design and Markup languages: <em>{design}</em></p>
                        <p className="info" style={{ fontWeight: 'bold' }}>Consepts & Paradigms: <em>{consepts}</em></p>
                        <p className="info" style={{ fontWeight: 'bold' }}>Tools: <em>{tools}</em></p>
                        <p className="info" style={{ fontWeight: 'bold' }}>Frameworks: <em>{frameworks}</em></p>
                        <p className="info" style={{ fontWeight: 'bold' }}>Databases: <em>{databases}</em></p>
                        <p className="info" style={{ fontWeight: 'bold' }}>Libraries: <em>{libraries}</em></p>
                    </div>
                </div>
            </section>
        );
    }
}

export default Resume;
