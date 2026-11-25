import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'NurseryAppDemo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44305/',
    redirectUri: baseUrl,
    clientId: 'NurseryAppDemo_App',
    responseType: 'code',
    scope: 'offline_access NurseryAppDemo',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44305',
      rootNamespace: 'NurseryAppDemo',
    },
  },
} as Environment;
