import React, { useState } from "react";

import backgroundImageButton from "../../../../assets/images/backgroundButton.png"
import { RegistrationForm } from "../RegistrationForm";

const AuthorizationForm: React.FC = () => {
  const [login, setLogin] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [showRegistrationForm, setShowRegistrationForm] = useState(false);

  return (
    <div className="relative flex h-screen w-screen items-center justify-center">
      <video
        autoPlay
        muted
        loop
        className="absolute inset-0 h-full w-full object-cover"
      >
        <source
          src="https://blz-contentstack-assets.akamaized.net/v3/assets/blt9c12f249ac15c7ec/blt4b52476e49bbe1bf/624476b50f303644adfe5dd0/gingerbread_animatic.webm"
          type="video/webm"
        />
      </video>
      <div className="absolute w-64">
        {showRegistrationForm ? (
          <RegistrationForm />
        ) : (
          <>
            <input
              className="  mb-4 w-full rounded border p-2"
              onChange={(e) => setLogin(e.target.value)}
              value={login}
              type="text"
              placeholder="Email"
            />
            <input
              className=" mb-4 w-full rounded border p-2"
              onChange={(e) => setPassword(e.target.value)}
              value={password}
              type="password"
              placeholder="Password"
            />
            <div className="flex justify-between">
            <button className="relative flex items-center justify-center w-64 h-12 bg-gray-500 rounded-md overflow-hidden">
              <img src={backgroundImageButton} alt="Background" className="absolute inset-0 w-full h-full" />
              <span className="text-gold text-sm font-bold z-10">Авторизация</span>
            </button>
              <button
                className="relative flex items-center justify-center w-64 h-12 bg-gray-500 rounded-md overflow-hidden"
                onClick={() => setShowRegistrationForm(true)}
              >
<img src={backgroundImageButton} alt="Background" className="absolute inset-0 w-full h-full" />
                <span className="text-gold text-sm font-bold z-10">Регистрация</span>
              </button>
            </div>
          </>
        )}
      </div>
    </div>
  );
};

export { AuthorizationForm };
