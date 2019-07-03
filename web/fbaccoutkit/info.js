import React, { Component } from 'react';
import { View, Image, TextInput } from 'react-native';
import Button from 'react-native-button';
export default class Info extends Component {
  // static navigationOptions = {
  //   headerRight: (
  //     <Button
  //       onPress={() => {
  //         this.props.navigation.navigate('Home')
  //       }}
  //       style={{
  //         color: 'black',
  //         marginRight: 20
  //       }}
  //     >Bỏ qua</Button>
  //   ),
  // };

 
  constructor(props) {
    super(props);
    this.state = {
      text1: '',
      text2: '',
      text3: '',
      text4: ''
    };
  }

  render() {
    return (
      <View >
        <Image
          style={{
            width: 120, height: 120, marginTop: 10, marginLeft: 130
          }}
          source={require('./img/img1.png')}
        />
        <TextInput
          style={{ height: 40, borderColor: 'gray', borderWidth: 1, marginLeft: 50, marginRight: 50, marginTop: 20, borderRadius: 7 }}
          onChangeText={(text1) => this.setState({ text1 })}
          placeholder='Họ và tên'
        />
        <TextInput
          style={{ height: 40, borderColor: 'gray', borderWidth: 1, marginLeft: 50, marginRight: 50, marginTop: 20, borderRadius: 7 }}
          onChangeText={(text2) => this.setState({ text2 })}
          placeholder='Email'
        />
        <TextInput
          style={{ height: 40, borderColor: 'gray', borderWidth: 1, marginLeft: 50, marginRight: 50, marginTop: 20, borderRadius: 7 }}
          onChangeText={(text3) => this.setState({ text3 })}
          placeholder='Ngày sinh'
        />
        <TextInput
          style={{ height: 40, borderColor: 'gray', borderWidth: 1, marginLeft: 50, marginRight: 50, marginTop: 20, borderRadius: 7 }}
          onChangeText={(text4) => this.setState({ text4 })}
          placeholder='Địa chỉ'
        />

        <Button
          onPress={() => {
            this.props.navigation.navigate('Home')
          }}
          style={{
            marginTop: 80,
            padding: 15,
            color: 'white',
            backgroundColor: '#841584'
          }}
        >Cập nhật thông tin</Button>
        
        
      </View>


    );
  }
}

