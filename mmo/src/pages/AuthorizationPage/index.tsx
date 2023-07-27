import {
  AuthorizationForm,
  RegistrationForm,
} from "../../modules/AuthorizationModels";
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
