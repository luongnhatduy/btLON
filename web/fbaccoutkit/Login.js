/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow
 * @lint-ignore-every XPLATJSCOPYRIGHT1
 */

import React, { Component } from 'react';
import { Text, View, TouchableOpacity } from 'react-native';
import RNAccountKit from 'react-native-facebook-account-kit';
// import { Route } from './Router';



export default class Login extends Component {
  _loginWithPhone() {
    RNAccountKit.loginWithPhone()
      .then((token) => {
        if (!token) {
          console.log('Đăng nhập thất bại')
        } else {
            console.log('Đăng nhập oki')
            this.props.navigation.navigate('Info')
        }
      })
  }

  _loginWithEmail() {
    RNAccountKit.loginWithEmail()
      .then((token) => {
        if (!token) {
          console.log('Đăng nhập thất bại')
        } else {
          console.log(token)
        }
      })
  }
  render() {
    return (      
      <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
        <Text style={{ textAlign: 'center', marginBottom: 10 }}>Demo FaceBook Account Kit </Text>
        <TouchableOpacity style={{ marginBottom: 10, borderColor: 'green', borderWidth: 1, borderRadius: 3, padding: 5 }} onPress={() => this._loginWithPhone()}>
          <Text>Đăng nhập bằng số điện thoại</Text>
        </TouchableOpacity>
        <TouchableOpacity style={{ borderColor: 'red', borderWidth: 1, borderRadius: 3, padding: 5 }} onPress={() => this._loginWithEmail()}>
          <Text>Đăng nhập bằng email</Text>
        </TouchableOpacity>
      </View>    
    );
  }
}


