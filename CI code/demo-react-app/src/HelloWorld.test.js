import { shallow } from "enzyme";
import HelloWorld from "./HelloWorld";
import React from "react";

describe('HelloWorld Component', () => {
    it('renders the greeting message', () => {
      const wrapper = shallow(<HelloWorld/>);  
      expect(wrapper.text()).toBe('Hello World!');
    });
  });
