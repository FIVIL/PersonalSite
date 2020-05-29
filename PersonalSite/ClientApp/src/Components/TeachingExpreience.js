import React, { Component } from 'react';

class TeachingExpreience extends Component {
    render() {

        if (this.props.data) {
            var teaching = this.props.data.expreiences.map(function (exp) {
                return <li>
                    <p className="info"><span>&bull;</span> <em className="date" style={{ fontWeight: 'bold' }}>{exp.year}</em>, {exp.title} ,<em style={{ fontWeight: 'bold' }}>{exp.course}</em>, <em>{exp.institue}</em>, Instructor: <em>{exp.instructor}</em></p>
                </li>
            })

            var talks = this.props.data.talks.map(function (talk) {
                var projectImage = 'images/' + talk.image;
                return <div key={talk.description} className="portfolio-item">
                    <div className="item-wrap">
                        <a href={talk.link} title={talk.subject} target="_blank">
                            <img alt={talk.subject} src={projectImage} />
                            <div className="overlay">
                                <div className="portfolio-item-meta">
                                    <h5>{talk.subject}</h5>
                                    <p>{talk.description}</p>
                                </div>
                            </div>
                            <div className="link-icon"><i className="fa fa-link"></i></div>
                        </a>
                    </div>
                </div>
            })
        }

        return (
            <section id="teachingExpreience">
                <br />
                <div className="text-container">
                    <div className="row">

                        <div className="four columns">
                            <p>Talks.</p>

                            <div id="talk-wrapper" className="bgrid-quarters s-bgrid-thirds cf">
                                {talks}
                            </div>
                        </div>

                        <div className="eight columns flex-container">
                            <ul className="slides">
                                {teaching}
                            </ul>
                        </div>
                    </div>
                </div>
            </section>
        );
    }
}

export default TeachingExpreience;
