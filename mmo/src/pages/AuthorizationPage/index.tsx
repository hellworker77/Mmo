import {
  AuthorizationForm,
  RegistrationForm,
} from "../../modules/AuthorizationModules";
import React from "react";

const AuthorizationPage: React.FC = () => {
  return (
    <div>
      <AuthorizationForm />
      <RegistrationForm />
    </div>
  );
};

export default AuthorizationPage;
