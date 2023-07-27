import React from "react";

import {
  AuthorizationForm,
  RegistrationForm,
} from "../../modules/AuthorizationModels";

const AuthorizationPage: React.FC = () => {
  return (
    <div>
      <AuthorizationForm />
      <RegistrationForm />
    </div>
  );
};

export default AuthorizationPage;
