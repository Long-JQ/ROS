import React, { Component } from 'react';
import './App.css';
import { Layout } from 'antd';
import { Menu, Icon, Button } from 'antd';
import { BrowserRouter as Router, Route, Switch, Redirect, NavLink, Link } from 'react-router-dom'
import Bill from './pages/Bill.js'
import Food from './pages/Food.js'
import Order from './pages/Order.js'
import Store from './pages/Store.js'
import User from './pages/User.js'
import Seat from './pages/Seat.js'
import './config.js'

const { Header, Footer, Sider, Content } = Layout;

const SubMenu = Menu.SubMenu;

class App extends React.Component {
  state = {
    collapsed: false,
  }

  toggleCollapsed = () => {
    this.setState({
      collapsed: !this.state.collapsed,
    });
  }

  render() {
    return (<Router>
      <Layout style={{ minHeight: '100vh' }}>
        <Sider trigger={null}
          collapsible
          collapsed={this.state.collapsed}>
          <div >

            <Menu
              defaultSelectedKeys={['1']}
              defaultOpenKeys={['sub1']}
              mode="inline"
              theme="dark"
              inlineCollapsed={this.state.collapsed}
            >
              <Menu.Item key="1" >
                <Link to='/Food'>
                  <Icon type="pie-chart" />
                  <span>Food</span>
                </Link>
              </Menu.Item>

              <Menu.Item key="2"><Link to='/Bill'>
                <Icon type="desktop" />
                <span>Bill</span></Link>
              </Menu.Item>
              <Menu.Item key="3">
                <Link to='/Order'>
                  <Icon type="pie-chart" />
                  <span>Order</span>
                </Link>
              </Menu.Item>
              <Menu.Item key="4">
                <Link to='/Store'>
                  <Icon type="pie-chart" />
                  <span>Store</span>
                </Link>
              </Menu.Item>
              <Menu.Item key="5">
                <Link to='/User'>
                  <Icon type="pie-chart" />
                  <span>User</span>
                </Link>
              </Menu.Item>
              <Menu.Item key="6">
                <Link to='/Seat'>
                  <Icon type="pie-chart" />
                  <span>Seat</span>
                </Link>
              </Menu.Item>
            </Menu>

          </div>
        </Sider>
        <Layout>
          <Header style={{ background: '#fff', padding: 0 }}>
            <Icon
              className="trigger"
              type={this.state.collapsed ? 'menu-unfold' : 'menu-fold'}
              onClick={this.toggleCollapsed}
            />
            <Icon className="trigger floatLeft" type="user" theme="outlined" />
            <Icon className="trigger floatLeft" type="mail" theme="outlined" />

          </Header>
          <Content style={{ margin: '24px 16px', padding: 24, background: '#fff', minHeight: 280 }}>
          <Route path="/Food" component={Food} />
          <Route path="/Bill" component={Bill} />
          <Route path="/Order" component={Order} />
          <Route path="/Store" component={Store} />
          <Route path="/User" component={User} />
          <Route path="/Seat" component={Seat} />
          </Content>
        </Layout>
      </Layout></Router>
    );
  }
}


export default App;