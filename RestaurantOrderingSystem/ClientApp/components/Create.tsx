import * as React from 'react';
import { RouteComponentProps } from 'react-router';

interface CounterState {
    currentCount: number;
    name: string;
}

export class Create extends React.Component<RouteComponentProps<{}>, CounterState> {
    constructor() {
        super();
        this.state = { currentCount: 0 ,name:"1"};
        fetch("api/Default/ndex")
            .then(response => response.json() as Promise<string>)
            .then(data => {
                alert("1");
                this.setState({ currentCount: 0, name: data});
            });
    }
    public render() {
        return <div>
            <h1>{this.state.name}</h1>

            <p>This is a simple example of a React component.</p>

            <p>Current count: <strong>{this.state.currentCount}</strong></p>

            <button onClick={() => { this.incrementCounter() }}>Increment</button>
        </div>;
    }

    incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }
}
